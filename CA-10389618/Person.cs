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
using System.Text.RegularExpressions;

namespace CA_10389618
{
    public partial class Person : CA_10389618.Menu
    {

        public Person()
        {
            if (!User.admin)
            {
                addCourseToolStripMenuItem.Visible = false;
                addTeacherToolStripMenuItem.Visible = false;
                addStudentToolStripMenuItem.Visible = false;
                editCourseToolStripMenuItem.Visible = false;
                editStudentToolStripMenuItem.Visible = false;
                editTeacherToolStripMenuItem.Visible = false;
                courseManagementToolStripMenuItem.Visible = false;
                deleteCourseToolStripMenuItem.Visible = false;
                deleteStudentToolStripMenuItem.Visible = false;
                deleteTeacherToolStripMenuItem.Visible = false;
            }
            InitializeComponent();
        }

        //this method was written after I discovered a bug
        //if a teacher was deleted from the db, the previous and next buttons wouldn't have worked 
        //as the IDs were only increased or decreased by 1
        protected List<int> GetAllIDs()
        {
            int k = 0;
            string command = "";
            List<int> myIDs = new List<int>();
            SqlConnection conn = EstablishConnection();
            if (ActiveForm is AddStudent || ActiveForm is EditStudent || ActiveForm is DeleteStudent 
                || ActiveForm is ViewStudent)
            {
                command = "SELECT StudentID FROM Student ORDER BY StudentID ASC";
            }
            else if (ActiveForm is AddTeacher || ActiveForm is EditTeacher || ActiveForm is DeleteTeacher 
                || ActiveForm is ViewTeacher)
            {
                command = "SELECT TeacherID FROM Teacher ORDER BY TeacherID ASC";
                
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
        

        //method to clear form and add automated StudentID
        protected void ClearForm(int action)
        {
            cbCounty.DataSource = Enum.GetValues(typeof(County));
            int k = GetLastID(action);
            int St_ID = k + 1;
            txtAd1.Text = "";
            txtAd2.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = St_ID.ToString();
            cbCounty.SelectedItem = County.None;
            rbUndergraduate.Checked = true;
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }


        //method to check if everything is filled in
        protected void MustFillUp()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regex3 = new Regex("^.+@[^\\.].*\\.[a-z]{2,}$");
            if (ActiveForm is AddStudent || ActiveForm is EditStudent)
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || !regex.IsMatch(txtFirstName.Text))
                {
                    throw new FormatException("First name must be filled in and cannot contain numbers");
                }
                else if (string.IsNullOrEmpty(txtLastName.Text) || !regex.IsMatch(txtLastName.Text))
                {
                    throw new FormatException("Last name must be filled in and cannot contain numbers");
                }
                else if (string.IsNullOrEmpty(txtCountry.Text) || !regex.IsMatch(txtCountry.Text))
                {
                    throw new FormatException("Country must be filled in and cannot contain numbers");
                }
                else if (string.IsNullOrEmpty(txtCity.Text) || !regex.IsMatch(txtCity.Text))
                {
                    throw new FormatException("City must be filled in and cannot contain numbers");
                }
                else if (string.IsNullOrEmpty(txtAd1.Text))
                {
                    throw new FormatException("Address line 1 must be filled in");
                }
                else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    throw new FormatException("Phone number must be filled in and cannot contain letters");
                }
                else if (string.IsNullOrEmpty(txtEmail.Text) || !regex3.IsMatch(txtEmail.Text))
                {
                    throw new FormatException("Email number must be filled in and has to contain '@' ");
                }
            }
            else if (ActiveForm is AddTeacher || ActiveForm is EditTeacher)
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || !regex.IsMatch(txtFirstName.Text))
                {
                    throw new FormatException("First name must be filled in and cannot contain numbers");
                }
                else if (string.IsNullOrEmpty(txtLastName.Text) || !regex.IsMatch(txtLastName.Text))
                {
                    throw new FormatException("Last name must be filled in and cannot contain numbers");
                }
               
                else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    throw new FormatException("Phone number must be filled in and cannot contain letters");
                }
                else if (string.IsNullOrEmpty(txtEmail.Text) || !regex3.IsMatch(txtEmail.Text))
                {
                    throw new FormatException("Email number must be filled in and has to contain '@' ");
                }
            }
        }

        //retrieving information for selected student 
        protected void RetrieveInfoForSelectedStudent(int ID)
        {
            string stmt1 = "SELECT * FROM Student WHERE StudentID=@StudentID";
            DataTable dtbl = new DataTable();
            dtbl = UseDBWithDataTable(stmt1, "StudentID", ID);

            //getting information of selected student
            foreach (DataRow row in dtbl.Rows)
            {
                txtStudentID.Text = row["StudentID"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtLastName.Text = row["LastName"].ToString();
                txtCountry.Text = row["Country"].ToString();
                txtCity.Text = row["City"].ToString();
                txtAd1.Text = row["AddressLine1"].ToString();
                txtAd2.Text = row["AddressLine2"].ToString();
                txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();
                cbCounty.DataSource = Enum.GetValues(typeof(County));
                object lvl = Enum.Parse(typeof(Level), row["Level"].ToString());
                if (lvl.ToString() == "Undergraduate")
                {
                    rbUndergraduate.Checked = true;
                }
                else
                {
                    rbPostGraduate.Checked = true;
                }
                cbCounty.SelectedItem = Enum.Parse(typeof(County), row["County"].ToString());

            }
        }

        //retrieving information for selected teacher 
        protected void RetrieveInfoForSelectedTeacher(int ID)
        {
            string stmt1 = "SELECT * FROM Teacher WHERE TeacherID=@TeacherID";
            DataTable dtbl = new DataTable();
            dtbl = UseDBWithDataTable(stmt1, "TeacherID", ID);

            //getting information of selected student
            foreach (DataRow row in dtbl.Rows)
            {
                txtStudentID.Text = row["TeacherID"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtLastName.Text = row["LastName"].ToString();
                txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();

            }
        }

        //retrieving previous DB entry by ID
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int index = 0;
            List<int> myIds= GetAllIDs();
            int.TryParse(txtStudentID.Text, out int ID);
            index=myIds.IndexOf(ID);
            if (index != 0)
            {
                index--;
            }
            if (btnPrevious.FindForm() is EditStudent || btnPrevious.FindForm() is ViewStudent || 
                btnPrevious.FindForm() is DeleteStudent)
            {
                RetrieveInfoForSelectedStudent(myIds[index]);
            }
            else if 
                (btnPrevious.FindForm() is EditTeacher || btnPrevious.FindForm() is DeleteTeacher|| 
                btnPrevious.FindForm() is ViewTeacher)
            {
                RetrieveInfoForSelectedTeacher(myIds[index]);
            }
            
        }

        //retrieving next DB entry by ID
        private void btnNext_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStudentID.Text, out int ID);
            int index = 0;
            List<int> myIds = GetAllIDs();
            index = myIds.IndexOf(ID);
            if (index != myIds.Count - 1)
            {
                index++;
            }
            if (btnNext.FindForm() is EditStudent || btnNext.FindForm() is ViewStudent || 
                btnNext.FindForm() is DeleteStudent)
            {
                RetrieveInfoForSelectedStudent(myIds[index]);
               
            }
            else if
                (btnNext.FindForm() is EditTeacher || btnNext.FindForm()is DeleteTeacher || 
                btnNext.FindForm() is ViewTeacher)
            {
                RetrieveInfoForSelectedTeacher(myIds[index]);
            }

        }
    }
}
