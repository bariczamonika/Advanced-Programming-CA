using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CA_10389618
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        protected SqlConnection EstablishConnection()
        {
            SqlConnection conn;
            string cs = ConfigurationManager.ConnectionStrings["conn1"].ConnectionString;
            if (cs != null)
            {
                conn = new SqlConnection(cs);
                return conn;
            }
            else
            {
                throw new Exception("Connection string is empty");
            }
        }

        protected int GetLastID()
        {
            SqlConnection conn = EstablishConnection();
            int k = 0;
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                //retrieveing last record of database
                SqlCommand c = new SqlCommand("SELECT TOP 1 StudentID FROM Student ORDER BY StudentID DESC", conn);
                SqlDataReader reader = c.ExecuteReader();
                if (!reader.HasRows)
                {
                    k = 9999999;
                }
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out k);    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return k;
        }

        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login_Screen fl = new Login_Screen();
                fl.Show();

            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStudent fa = new AddStudent();
            fa.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FindInDB fdb = new FindInDB();
            fdb.Show();
        }

        protected void HitCancelButton()
        {
            if (MessageBox.Show("Are you sure you would like to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
        }

        protected DataTable UseDBWithDataTable(string sqlcmd, string variable, object k)
        {
            //todo write a method to avoid repetition
            DataTable dtbl = new DataTable();
            SqlConnection conn = EstablishConnection();
            try
            {
                
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd, conn);
                    variable = '@' + variable;
                    sqlDA.SelectCommand.Parameters.AddWithValue(variable, k);
                    sqlDA.Fill(dtbl);
                }   
                
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                
            }
            return dtbl;
        }
    }
}
