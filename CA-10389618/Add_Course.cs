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
    public partial class Add_Course : Course
    {
        public Add_Course()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            try
            {
                MustFillUpCourseForm();
                //insert into database
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                if (dtpEndDate.Value < dtpStartDate.Value)
                    throw new Exception("The end date cannot be earlier than the start date");
                string stmt1 = "INSERT INTO Course (CourseID, CourseName, CourseDescription, StartDate, EndDate, TeacherID) " +
                    "VALUES(@CourseID, @CourseName, @CourseDescription, @StartDate, @EndDate, @TeacherID);";
                SqlCommand cmd = new SqlCommand(stmt1, conn);
                cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text);
                cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
                cmd.Parameters.AddWithValue("@CourseDescription", rtbCourseDescription.Text);
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@TeacherID", GetTeacherIDByName(cbTeacher.SelectedItem.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course added");
                ClearCourseForm();
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

        private void Add_Course_Load(object sender, EventArgs e)
        {
            ClearCourseForm();
            btnNext.Visible = false;
            btnPrevious.Visible = false;
        }
    }
}
