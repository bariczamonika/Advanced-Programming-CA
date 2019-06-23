using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_10389618
{
    public partial class EditTeacher : Person
    {
        public EditTeacher(int ID)
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedTeacher(ID);
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you would like to make these changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = EstablishConnection();
                try
                {

                    //insert into database
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    MustFillUp();
                    string stmt1 = "UPDATE Teacher SET FirstName=@FirstName, LastName=@LastName,  PhoneNumber=@Phone, " +
                        "Email=@Email WHERE TeacherID=@TeacherID;";
                    SqlCommand cmd = new SqlCommand(stmt1, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                HitCancelButton();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
        }
    }
}
