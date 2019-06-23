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
    public partial class CourseManagement : Menu
    {
        public CourseManagement()
        {
            InitializeComponent();
        }

        // retrieve the student's ID by name
        protected int RetrieveStudentIDByFirstNameLastName(string fName, string lName)
        {
            int k = 0;
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Student WHERE FirstName=@FirstName AND LastName=@LastName", conn);
                cmd.Parameters.AddWithValue("@FirstName", fName);
                cmd.Parameters.AddWithValue("@LastName", lName);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out k);
                }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return k;
        }

        //get all the student names for the drop down list
        protected List<string> RetrieveStudentNames()
        {
            List<string> studentNames = new List<string>();
            SqlConnection conn = EstablishConnection();
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                conn.Open();
            string stmt = "SELECT FirstName, LastName FROM Student";
            SqlCommand cmd = new SqlCommand(stmt, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                studentNames.Add(reader[0].ToString() + " " + reader[1].ToString());
            }
            return studentNames;
        }


        //retrieve info for the selected student
        protected void RetrieveInfoForStudent(int ID)
        {
            string stmt = "SELECT * FROM Student WHERE StudentID=@StudentID";
            DataTable dtbl = new DataTable();
            dtbl = UseDBWithDataTable(stmt, "StudentID", ID);
            foreach (DataRow row in dtbl.Rows)
            {
                txtAd1.Text = row["AddressLine1"].ToString();
                txtAd2.Text = row["AddressLine2"].ToString();
                txtCity.Text = row["City"].ToString();
                txtCountry.Text = row["Country"].ToString();
                txtCounty.Text = Enum.Parse(typeof(County), row["County"].ToString()).ToString();
                txtEmail.Text = row["Email"].ToString();
                txtPhone.Text = row["PhoneNumber"].ToString();
                //ez kell mashova is 
                txtLevel.Text = Enum.Parse(typeof(Level), row["Level"].ToString()).ToString();
                txtStudentID.Text = row["StudentID"].ToString();
            }

        }


        //retrieve all the course names
        protected List<string> RetrieveCourseNames()
        {
            List<string> courseNames = new List<string>();
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                string stmt = "SELECT CourseName FROM Course";
                SqlCommand cmd = new SqlCommand(stmt, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    courseNames.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return courseNames;
        }


        //retrieve course ID by the course name
        protected int RetrieveCourseIDByName(string name)
        {
            int k = 0;
            SqlConnection conn = EstablishConnection();
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CourseID FROM Course WHERE CourseName=@CourseName", conn);
                cmd.Parameters.AddWithValue("@CourseName", name);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out k);
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return k;
        }

        //retrieve the info for the course
        protected void RetrieveInfoForCourse(int ID)
        {
            int teacherID=0;
            string stmt = "SELECT * FROM Course WHERE CourseID=@CourseID";
            DataTable dtbl = new DataTable();
            dtbl = UseDBWithDataTable(stmt, "CourseID", ID);
            foreach (DataRow row in dtbl.Rows)
            {
                txtCourseID.Text = row["CourseID"].ToString();
                txtStartDate.Text = row["StartDate"].ToString();
                txtEndDate.Text = row["EndDate"].ToString();
                rtbDescription.Text = row["CourseDescription"].ToString();
                txtTeacherID.Text = row["TeacherID"].ToString();
                int.TryParse(row["TeacherID"].ToString(), out teacherID);

            }
            string stmt2 = "SELECT * FROM Teacher WHERE TeacherID=@TeacherID;";
            DataTable dtbl2 = new DataTable();
            dtbl2 = UseDBWithDataTable(stmt2, "TeacherID", teacherID);
            //SqlDataAdapter sqlDA = new SqlDataAdapter(stmt2, conn);
            //sqlDA.SelectCommand.Parameters.AddWithValue(variable, k);
            //sqlDA.Fill(dtbl);
            foreach (DataRow row in dtbl2.Rows)
            {

                txtTeacherEmail.Text = row["Email"].ToString();
                txtTeacherPhone.Text = row["PhoneNumber"].ToString();
                txtTeacherName.Text = row["FirstName"].ToString() + " " + row["LastName"].ToString();
            }

        }

        protected void MustFillUpCourseManagement()
        {
            if (txtCost.Text == "")
                throw new Exception("Cost of the course must be filled up");
            
        }

        private void cbStudentName_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {

            cbStudentName.DataSource = RetrieveStudentNames();
            cbCourseName.DataSource = RetrieveCourseNames();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
         
        }

        private void cbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] studentName = cbStudentName.SelectedItem.ToString().Split(' ');
            int ID=RetrieveStudentIDByFirstNameLastName(studentName[0], studentName[1]);
            RetrieveInfoForStudent(ID);
            
        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = cbCourseName.SelectedItem.ToString();
            int CID = RetrieveCourseIDByName(courseName);
            RetrieveInfoForCourse(CID);
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = EstablishConnection();
            decimal cost = 0;
            
            try
            {
                MustFillUpCourseManagement();
                //insert into database
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                string stmt1 = "INSERT INTO CourseManagement (CourseID, StudentID,Cost) " +
                    "VALUES(@CourseID, @StudentID,@Cost);";
                SqlCommand cmd = new SqlCommand(stmt1, conn);
                cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text);
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                decimal.TryParse(txtCost.Text, out cost);
                cmd.Parameters.AddWithValue("@Cost", cost);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Enrolled");
               
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
            txtCost.Text = "";
        }

    }
}
