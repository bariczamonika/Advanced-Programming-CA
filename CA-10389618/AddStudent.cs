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
    public partial class AddStudent : Student
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        //method to clear form and add automated StudentID
        protected void ClearForm()
        {
            cbCounty.DataSource = Enum.GetValues(typeof(County));
            cbLevel.DataSource = Enum.GetValues(typeof(Level));
            int k = GetLastID();
            int St_ID = k + 1;
            txtAd1.Text = "";
            txtAd2.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = St_ID.ToString();
            cbCounty.SelectedItem = County.None;
            cbLevel.SelectedItem = Level.Undergraduate;
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
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
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@County", cbCounty.SelectedItem);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@AddressLine1", txtAd1.Text);
                cmd.Parameters.AddWithValue("@AddressLine2", txtAd2.Text);
                cmd.Parameters.AddWithValue("@Level", cbLevel.SelectedItem);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added");
                ClearForm();
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
            ClearForm();
        }
    }
}
