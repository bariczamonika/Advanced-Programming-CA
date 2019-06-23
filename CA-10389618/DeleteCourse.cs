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
    public partial class DeleteCourse : Course
    {
        public DeleteCourse(int ID)
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedCourse(ID);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you would like to make these changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = EstablishConnection();
                try
                {

                    //delete from database
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    string stmt1 = "DELETE FROM Course WHERE CourseID=@CourseID;";
                    string stmt2 = "DELETE FROM CourseManagement WHERE CourseID=@CourseID;";
                    SqlCommand cmd = new SqlCommand(stmt1, conn);
                    SqlCommand cmd2 = new SqlCommand(stmt2, conn);
                    cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text);
                    cmd2.Parameters.AddWithValue("@CourseID", txtCourseID.Text);
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course deleted");
                    this.Close();
                    MainScreen m = new MainScreen();
                    m.Show();
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
    }
    
}
