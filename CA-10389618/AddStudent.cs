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

namespace CA_10389618
{
    public partial class AddStudent : Person
    {
        public AddStudent()
        {
            InitializeComponent();
        }




        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            try
            {

                //insert into database
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                MustFillUp();
                string stmt1 = "INSERT INTO Student (StudentID, FirstName, LastName, Country, County, City, AddressLine1, AddressLine2, Level, PhoneNumber, Email) " +
                    "VALUES(@StudentID,@FirstName, @LastName, @Country, @County, @City, @AddressLine1, @AddressLine2, @Level, @Phone, @Email);";
                SqlCommand cmd = new SqlCommand(stmt1, conn);
                Level lvl = Level.Undergraduate;
                if (rbPostGraduate.Checked == true)
                    lvl = Level.Postgraduate;
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@County", cbCounty.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@AddressLine1", txtAd1.Text);
                cmd.Parameters.AddWithValue("@AddressLine2", txtAd2.Text);
                cmd.Parameters.AddWithValue("@Level", lvl.ToString());
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added");
                ClearForm(1);
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            HitCancelButton();
        }

        private void AddStudent_Load_1(object sender, EventArgs e)
        {
            ClearForm(1);
            btnNext.Visible = false;
            btnPrevious.Visible = false;
            
        }
    }
}
