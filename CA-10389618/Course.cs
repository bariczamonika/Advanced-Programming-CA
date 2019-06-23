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
    public partial class Course: Menu
    {
        public Course()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
        }


        //returns all the course ids in the database
        protected List<int> GetAllIDs()
        {
            int k = 0;
            string command = "";
            List<int> myIDs = new List<int>();
            SqlConnection conn = EstablishConnection();
            if (ActiveForm is Course)
            {
                command = "SELECT CourseID FROM Course ORDER BY CourseID ASC";
            }
            
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                SqlCommand c = new SqlCommand(command, conn);
                SqlDataReader reader = c.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out k);
                    myIDs.Add(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return myIDs;
        }

        //get the list of teachers for the drop down list
        protected List<string> GetTeacherList()
        {
            List<string> myTeacherList = new List<string>();
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Teacher", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    myTeacherList.Add(reader[0].ToString()+" "+reader[1].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return myTeacherList;
        }


        // a method to get a teacher's name by ID
        protected string GetTeacherNameByID(int ID)
        {
            string fullName = "";
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Teacher WHERE TeacherID=@TeacherID", conn);
                cmd.Parameters.AddWithValue("@TeacherID", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fullName=(reader[0].ToString() + " " + reader[1].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return fullName;
        }

        //a method to get the teacher's ID by name
        protected int GetTeacherIDByName(string fullName)
        {
            SqlConnection conn = EstablishConnection();
            string[] teacherName = fullName.Split(' ');
            int ID=0;
            try
            {
                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TeacherID FROM Teacher WHERE FirstName=@FirstName AND LastName=@LastName", conn);
                cmd.Parameters.AddWithValue("@FirstName", teacherName[0]);
                cmd.Parameters.AddWithValue("@LastName", teacherName[1]);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ID;
        }


        

        protected void ClearCourseForm()
        {
            txtCourseID.Text = (GetLastID(3)+1).ToString();
            txtCourseName.Text = "";
            rtbCourseDescription.Text = "";
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = dtpStartDate.Value;
            cbTeacher.DataSource = GetTeacherList();

        }

        //checks is the course form is filled up or not
        protected void MustFillUpCourseForm()
        {
            if (txtCourseName.Text == "")
                throw new Exception("Course name must be filled up");
            else if (rtbCourseDescription.Text=="")
                throw new Exception("Course description must be filled up");
        }


        //retrieve info for the selected course
        protected void RetrieveInfoForSelectedCourse(int ID)
        {
            string stmt1 = "SELECT * FROM Course WHERE CourseID=@CourseID";
            DataTable dtbl = new DataTable();
            dtbl = UseDBWithDataTable(stmt1, "CourseID", ID);

            //getting information of selected student
            foreach (DataRow row in dtbl.Rows)
            {
                txtCourseID.Text = row["CourseID"].ToString();
                txtCourseName.Text = row["CourseName"].ToString();
                rtbCourseDescription.Text = row["CourseDescription"].ToString();
                dtpStartDate.Text = row["StartDate"].ToString();
                dtpEndDate.Text = row["EndDate"].ToString();
                cbTeacher.DataSource = GetTeacherList();
                cbTeacher.SelectedItem = GetTeacherNameByID(int.Parse(row["TeacherID"].ToString()));

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCourseID.Text, out int ID);
            int index = 0;
            List<int> myIds = GetAllIDs();
            index = myIds.IndexOf(ID);
            if (index != 0)
            {
                index--;
            }
            if (btnPrevious.FindForm() is EditCourse || btnPrevious.FindForm() is ViewCourse || btnPrevious.FindForm() is DeleteCourse)
            {
                RetrieveInfoForSelectedCourse(myIds[index]);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCourseID.Text, out int ID);
            int index = 0;
            List<int> myIds = GetAllIDs();
            index = myIds.IndexOf(ID);
            if (index != myIds.Count-1)
            {
                index++;
            }
            if (btnPrevious.FindForm() is EditCourse || btnPrevious.FindForm() is ViewCourse|| btnPrevious.FindForm() is DeleteCourse)
            {
                RetrieveInfoForSelectedCourse(myIds[index]);
            }
            
        }
    }
}
