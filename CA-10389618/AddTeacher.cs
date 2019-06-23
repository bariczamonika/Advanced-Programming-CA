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
    public partial class AddTeacher : Person
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            ClearForm(2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            try
            {

                //insert into database
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                MustFillUp();
                string stmt1 = "INSERT INTO Teacher (TeacherID, FirstName, LastName, PhoneNumber, Email) " +
                    "VALUES(@TeacherID,@FirstName, @LastName, @Phone, @Email);";
                SqlCommand cmd = new SqlCommand(stmt1, conn);
                cmd.Parameters.AddWithValue("@TeacherID", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher added");
                ClearForm(2);
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
    }
}
