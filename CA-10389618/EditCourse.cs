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
    public partial class EditCourse : Course
    {
        public EditCourse(int ID)
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedCourse(ID);
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
            DialogResult dr = MessageBox.Show("Are you sure you would like to make these changes?", 
                "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = EstablishConnection();
                try
                {

                    //insert into database
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    MustFillUpCourseForm();
                    if (dtpEndDate.Value < dtpStartDate.Value)
                        throw new Exception("The end date cannot be earlier than the start date");
                    string stmt1 = "UPDATE Course SET CourseName=@CourseName, CourseDescription=@CourseDescription, " +
                        "StartDate=@StartDate, " +
                        "EndDate=@EndDate, TeacherID=@TeacherID WHERE CourseID=@CourseID;";
                    SqlCommand cmd = new SqlCommand(stmt1, conn);
                    cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text);
                    cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
                    cmd.Parameters.AddWithValue("@CourseDescription", rtbCourseDescription.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    cmd.Parameters.AddWithValue("@TeacherID", GetTeacherIDByName(cbTeacher.SelectedItem.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course updated");
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
