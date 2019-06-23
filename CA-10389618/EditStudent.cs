using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CA_10389618
{
    public partial class EditStudent : Person
    {
        public EditStudent(int ID)
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedStudent(ID);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Are you sure you would like to make these changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr== DialogResult.Yes)
            {
                SqlConnection conn = EstablishConnection();
                try
                {

                    //insert into database
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    MustFillUp();
                    string stmt1 = "UPDATE Student SET FirstName=@FirstName, LastName=@LastName, Country=@Country, " +
                        "County=@County, City=@City, AddressLine1=@AddressLine1, AddressLine2=@AddressLine2, " +
                        "Level=@Level, PhoneNumber=@Phone, Email=@Email WHERE StudentID=@StudentID;";
                    SqlCommand cmd = new SqlCommand(stmt1, conn);
                    Level lvl = Level.Undergraduate;
                    if (rbPostGraduate.Checked == true)
                        lvl = Level.Postgraduate;
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@County", cbCounty.SelectedItem);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@AddressLine1", txtAd1.Text);
                    cmd.Parameters.AddWithValue("@AddressLine2", txtAd2.Text);
                    cmd.Parameters.AddWithValue("@Level", lvl);
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated");
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
            else if (dr==DialogResult.Cancel)
            {
                HitCancelButton();
            }
            
        }
    }
 }

