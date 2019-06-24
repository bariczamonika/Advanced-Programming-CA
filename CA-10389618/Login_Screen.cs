using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace CA_10389618
{
    public partial class Login_Screen : Menu
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        

        
        private string hashPassword(string password)
        {
            //creating the salt for the password
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //get the hash value
            Rfc2898DeriveBytes hashValue = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = hashValue.GetBytes(20);
            //combine the salt and password
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            //store the hashed password as string 
            return Convert.ToBase64String(hashBytes);
        }

        private bool CheckSecurePassword(string pWord, string savedHashedPassword)
        {
            bool ok = false;
            //extract the bytes
            byte[] hashBytes = Convert.FromBase64String(savedHashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            //check the hash on the password the user entered
            var password = new Rfc2898DeriveBytes(pWord, salt, 10000);
            byte[] hash = password.GetBytes(20);
            //compare the results
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    throw new UnauthorizedAccessException();
                else
                    ok=true;
            return ok;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            bool ok = false;
     
            try
            {


                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("User name must be filled in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password must be filled in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string uName = txtUserName.Text;
                    string pWord = txtPassword.Text;
           
                    
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Users WHERE Username=@Username",conn);
                    cmd.Parameters.AddWithValue("@Username", uName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Incorrect username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ok = false;
                    }
                    else
                    {
                        ok = true;
                        reader.Close();
                    }

                    if(ok==true)
                    {
                        //get the hashed password from DB
                        SqlCommand cm = new SqlCommand("SELECT Password FROM dbo.Users WHERE Username=@Username",conn);
                        cm.Parameters.AddWithValue("@Username", uName);
                        SqlDataReader rdr = cm.ExecuteReader();
                        rdr.Read();
                        string savedHashedPassword = rdr.GetString(0);
                        if (CheckSecurePassword(pWord, savedHashedPassword))
                        {
                            if (uName=="Admin")
                            {
                                User.admin = true;
                            }
                            else
                            {
                                User.admin = false;
                            }
                            this.Hide();
                            MainScreen mc = new MainScreen();
                            mc.Show();
                        }

                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conn.Close(); }

        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            studentToolStripMenuItem.Visible = false;
            courseToolStripMenuItem.Visible = false;
            teacherToolStripMenuItem.Visible = false;
            saveAsToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            courseManagementToolStripMenuItem.Visible = false;
            
        }

        // These buttons are only for representational purposes to add and remove users without a signup page
        private void btnClearUsers_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Users", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // These buttons are only for representational purposes to add and remove users without a signup page
        private void btnFillUsers_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Users(ID,Username,Password) " +
                    "VALUES(1,'Admin',@secPassword)", conn);
                cmd.Parameters.AddWithValue("@secPassword", hashPassword("password"));
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO dbo.Users(ID,Username,Password) VALUES(2,'Teacher',@secPassword)", conn);
                cmd.Parameters.AddWithValue("@secPassword", hashPassword("teacher"));
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO dbo.Users(ID,Username,Password) VALUES(3,'Testuser',@secPassword)", conn);
                cmd.Parameters.AddWithValue("@secPassword", hashPassword("test1234"));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // These buttons are only for representational purposes to add and remove users without a signup page
        private void btnShowUsersAndPasswords_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User1: Admin, Password:password {Environment.NewLine}User2: Teacher, Password:teacher {Environment.NewLine}User3:Testuser, Password:test1234");
        }


        //hitting enter instead of submit button
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}
