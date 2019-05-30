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
    public partial class Student : CA_10389618.Menu
    {


        public Student()
        {
            InitializeComponent();
        }


        //method to clear form and add automated StudentID
        protected void ClearForm()
        {
            cbCounty.DataSource = Enum.GetValues(typeof(County));
            cbLevel.DataSource = Enum.GetValues(typeof(Level));
            int k = GetLastID();
            int St_ID = k+1;
            txtAd1.Text = "";
            txtAd2.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = St_ID.ToString();
            cbCounty.SelectedItem = County.None;
            cbLevel.SelectedItem = Level.Undergraduate;

        }


        //method to check if everything is filled in
        protected void MustFillUp()
        {
            if (string.IsNullOrEmpty(txtAd1.Text))
            {
                MessageBox.Show("Address must be filled in", "Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City must be filled in","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("City must be filled in","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("City must be filled in","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("City must be filled in","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                string stmt1 = "INSERT INTO Student (StudentID, FirstName, LastName, Country, County, City, AddressLine1, AddressLine2, Level) " +
                    "VALUES(@StudentID,@FirstName, @LastName, @Country, @County, @City, @AddressLine1, @AddressLine2, @Level);";
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
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                ClearForm();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you would like to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ClearForm();
            }
            
        }

        private void Student_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
