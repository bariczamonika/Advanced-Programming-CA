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
    public partial class CourseManagementInfo : Menu
    {
        public CourseManagementInfo()
        {
            
            InitializeComponent();
            if (!User.admin)
            {
                addCourseToolStripMenuItem.Visible = false;
                addTeacherToolStripMenuItem.Visible = false;
                addStudentToolStripMenuItem.Visible = false;
                editCourseToolStripMenuItem.Visible = false;
                editStudentToolStripMenuItem.Visible = false;
                editTeacherToolStripMenuItem.Visible = false;
                enrollStudentToolStripMenuItem.Visible = false;
                deleteCourseToolStripMenuItem.Visible = false;
                deleteStudentToolStripMenuItem.Visible = false;
                deleteTeacherToolStripMenuItem.Visible = false;
                cbStudentName.Visible = false;
                btnSubmit.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            InitializeDataTableForCourseInfo();
    
        }

        protected void InitializeDataTableForCourseInfo()
        {
            
            SqlConnection conn = EstablishConnection();
            try
            {
                int CourseID = 0;
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                string stmt1 = "SELECT TOP 1 Course.CourseID, Course.CourseName, Course.StartDate, Course.EndDate, Teacher.FirstName, Teacher.LastName, " +
                "Count(CourseManagement.StudentID) AS \"TotalStudent\", SUM(CourseManagement.Cost) AS \"TotalIncome\" " +
                "FROM CourseManagement INNER JOIN Course ON Course.CourseID = CourseManagement.CourseID " +
                "INNER JOIN Teacher ON Teacher.TeacherID = Course.TeacherID GROUP BY Course.CourseID, Course.CourseName, Course.StartDate, Course.EndDate, Teacher.FirstName, Teacher.LastName";
                string stmt2 = "SELECT Student.StudentID, Student.FirstName, Student.LastName, CourseManagement.Cost " +
                    "FROM CourseManagement " +
                    "INNER JOIN Student ON CourseManagement.StudentID = Student.StudentID WHERE CourseManagement.CourseID = @CourseID";

                DataTable dtbl = new DataTable();
                dtbl = UseDBWithDataTable(stmt1, "", "");
                
                //getting information of selected student
                foreach (DataRow row in dtbl.Rows)
                {
                    CourseID = int.Parse(row["CourseID"].ToString());
                    txtCourseID.Text=(row["CourseID"]).ToString();
                    txtCourseName.Text = row["CourseName"].ToString();
                    txtStartDate.Text = row["StartDate"].ToString();
                    txtEndDate.Text = row["EndDate"].ToString();
                    txtTeacher.Text = row["FirstName"].ToString()+" " +row["LastName"].ToString();
                    txtTotalStudents.Text = row["TotalStudent"].ToString();
                    txtIncome.Text = row["TotalIncome"].ToString();

                }
                DataTable dtbl2 = new DataTable();
                dtbl2 = UseDBWithDataTable(stmt2, "CourseID", CourseID);
                dgvCourseManInfo.DataSource = dtbl2;
                List<string> studentNames = new List<string>();
                foreach (DataRow row in dtbl2.Rows)
                {  
                    studentNames.Add(row["FirstName"].ToString() + " " + row["LastName"].ToString());
                }
                cbStudentName.DataSource = studentNames;
                txtStudentID.Text = dtbl2.Rows[0][0].ToString();
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

        protected void FillDataTableForCourseManInfo (int ID)
        {
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                string stmt1 = "SELECT Course.CourseID, Course.CourseName, Course.StartDate, Course.EndDate, Teacher.FirstName, Teacher.LastName, " +
                "Count(CourseManagement.StudentID) AS \"TotalStudent\", SUM(CourseManagement.Cost) AS \"TotalIncome\" " +
                "FROM CourseManagement INNER JOIN Course ON Course.CourseID = CourseManagement.CourseID " +
                "INNER JOIN Teacher ON Teacher.TeacherID = Course.TeacherID " +
                "WHERE CourseManagement.CourseID=@CourseID " +
                "GROUP BY Course.CourseID, Course.CourseName, Course.StartDate, Course.EndDate, Teacher.FirstName, Teacher.LastName";
                string stmt2 = "SELECT Student.StudentID, Student.FirstName, Student.LastName, CourseManagement.Cost " +
                    "FROM CourseManagement " +
                    "INNER JOIN Student ON CourseManagement.StudentID = Student.StudentID WHERE CourseManagement.CourseID = @CourseID";

                DataTable dtbl = new DataTable();
                dtbl = UseDBWithDataTable(stmt1, "CourseID", ID);

                //getting information of selected student
                foreach (DataRow row in dtbl.Rows)
                {
                    txtCourseID.Text = (row["CourseID"]).ToString();
                    txtCourseName.Text = row["CourseName"].ToString();
                    txtStartDate.Text = row["StartDate"].ToString();
                    txtEndDate.Text = row["EndDate"].ToString();
                    txtTeacher.Text = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                    txtTotalStudents.Text = row["TotalStudent"].ToString();
                    txtIncome.Text = row["TotalIncome"].ToString();

                }
                DataTable dtbl2 = new DataTable();
                dtbl2 = UseDBWithDataTable(stmt2, "CourseID", int.Parse(txtCourseID.Text));
                dgvCourseManInfo.DataSource = dtbl2;
                List<string> studentNames = new List<string>();
                foreach (DataRow row in dtbl2.Rows)
                {
                    studentNames.Add(row["FirstName"].ToString() + " " + row["LastName"].ToString());
                }
                txtStudentID.Text = dtbl2.Rows[0][0].ToString();
                cbStudentName.DataSource = studentNames;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                List<int> myIds = GetAllIDs();
                int.TryParse(txtCourseID.Text, out int ID);
                index = myIds.IndexOf(ID);
                
                if (index == -1)
                {
                    InitializeDataTableForCourseInfo();
                }
                else if (index != 0)
                {
                    index--;
                    FillDataTableForCourseManInfo(myIds[index]);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtCourseID.Text, out int ID);
                int index = 0;
                List<int> myIds = GetAllIDs();
                index = myIds.IndexOf(ID);
                if (index != myIds.Count - 1)
                {
                    index++;
                    FillDataTableForCourseManInfo(myIds[index]);
                }
                else if (index == -1)
                {
                    InitializeDataTableForCourseInfo();
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }

        private void dgvCourseManInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCourseManInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCourseManInfo.CurrentRow.Selected = true;
                    string ID = dgvCourseManInfo.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                    int.TryParse(ID, out int SID);
                    this.Close();
                    ViewStudent vs = new ViewStudent(SID);
                    vs.Show();
                }
            }
            catch { MessageBox.Show("Wrong cell has been clicked"); }
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

                    //delete from database
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                        conn.Open();
                    string stmt = "DELETE FROM CourseManagement WHERE StudentID=@StudentID";
                    SqlCommand cmd = new SqlCommand(stmt, conn);
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted");
                    this.Close();
                    CourseManagementInfo cmi = new CourseManagementInfo();
                    cmi.Show();
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

        private void cbStudentName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SqlConnection conn = EstablishConnection();
            
            try
            {
                
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                
                
                string stmt3 = "SELECT StudentID FROM Student WHERE FirstName=@FirstName AND LastName=@LastName";
                SqlCommand cmd = new SqlCommand(stmt3, conn);
                string[] name = cbStudentName.SelectedItem.ToString().Split(' ');
                cmd.Parameters.AddWithValue("@FirstName", name[0]);
                cmd.Parameters.AddWithValue("@LastName", name[1]);
                SqlDataReader rdr = cmd.ExecuteReader();
                int k = 0;
                while (rdr.Read())
                {
                    int.TryParse(rdr[0].ToString(), out k);

                }
                txtStudentID.Text = k.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }

