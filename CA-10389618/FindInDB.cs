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
using System.Configuration;

namespace CA_10389618
{
    public partial class FindInDB : Menu
    {
        protected int action { get; set; }
        public FindInDB()
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

        public FindInDB(int Action)
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
            action = Action;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                //depending on what was the previous click (what we are trying to retrieve from the database) 
                if (action == 1 || action == 2 || action == 3)
                {

                    if (txtByID.Text != "")
                    {

                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student " +
                            "WHERE StudentID=@StudentID", "StudentID", int.Parse(txtByID.Text));

                    }
                    else if (txtByFirstName.Text != "")
                    {
                        string k = '%' + txtByFirstName.Text + '%';
                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student " +
                            "WHERE FirstName LIKE @FirstName", "FirstName", k);

                    }
                    else if (txtByLastName.Text != "")
                    {
                        string k = '%' + txtByLastName.Text + '%';
                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student " +
                            "WHERE LastName LIKE @LastName", "LastName", k);
                    }
                }
                else if (action == 4 || action == 5 || action == 6)
                {
                    if (txtByID.Text != "")
                    {

                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Teacher " +
                            "WHERE TeacherID=@TeacherID", "TeacherID", int.Parse(txtByID.Text));

                    }
                    else if (txtByFirstName.Text != "")
                    {
                        string k = '%' + txtByFirstName.Text + '%';
                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Teacher " +
                            "WHERE FirstName LIKE @FirstName", "FirstName", k);

                    }
                    else if (txtByLastName.Text != "")
                    {
                        string k = '%' + txtByLastName.Text + '%';
                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Teacher " +
                            "WHERE LastName LIKE @LastName", "LastName", k);
                    }
                }
                else if (action == 7 || action == 8 || action == 9)
                {
                    if (txtByID.Text != "")
                    {

                        dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Course " +
                            "WHERE CourseID=@CourseID", "CourseID", int.Parse(txtByID.Text));

                    }
                    else if (txtByFirstName.Text != "")
                    {
                        string k = '%' + txtByFirstName.Text + '%';
                        dgStudent.DataSource = UseDBWithDataTable("SELECT Course.CourseID, " +
                    "Course.CourseName, " +
                    "Teacher.FirstName + ' ' + Teacher.LastName AS \"Teacher's name\" FROM Course  " +
                    "INNER JOIN Teacher  ON Course.TeacherID=Teacher.TeacherID " +
                    "WHERE Course.CourseName LIKE @CourseName", "CourseName", k);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
        }


        //if user clicks on the row they want to edit a new window comes up
        protected virtual void DgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgStudent.CurrentRow.Selected = true;


                    //edit student action
                    if (action == 1)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        EditStudent es = new EditStudent(SID);
                        es.Show();
                    }
                    //delete student action
                    else if (action == 2)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        DeleteStudent ds = new DeleteStudent(SID);
                        ds.Show();
                    }
                    //View student action
                    else if (action == 3)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        ViewStudent vs = new ViewStudent(SID);
                        vs.Show();
                    }
                    //edit teacher action
                    else if (action == 4)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["TeacherID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        EditTeacher et = new EditTeacher(SID);
                        et.Show();
                    }
                    //delete teacher action
                    else if (action == 5)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["TeacherID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        DeleteTeacher dt = new DeleteTeacher(SID);
                        dt.Show();
                    }
                    //view teacher action
                    else if (action == 6)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["TeacherID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        ViewTeacher vt = new ViewTeacher(SID);
                        vt.Show();
                    }
                    //edit course action
                    else if (action == 7)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["CourseID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        EditCourse ec = new EditCourse(SID);
                        ec.Show();
                    }
                    //delete course action
                    else if (action == 8)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["CourseID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        DeleteCourse dc = new DeleteCourse(SID);
                        dc.Show();
                    }
                    else if (action == 9)
                    {
                        string ID = dgStudent.Rows[e.RowIndex].Cells["CourseID"].FormattedValue.ToString();
                        int.TryParse(ID, out int SID);
                        this.Close();
                        ViewCourse vc = new ViewCourse(SID);
                        vc.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wrong cell has been clicked");
            }
        }

        //if user hits enter in textboxes button click executes
        private void txtByID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnFind_Click(this, new EventArgs());
            }
        }

        private void txtByFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(this, new EventArgs());
            }
        }

        private void txtByLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(this, new EventArgs());
            }
        }

        private void FindInDB_Load(object sender, EventArgs e)
        {
            if (action == 9 || action == 7 || action==8)
            {
                label2.Text = "Find by Course Name";
                label3.Visible = false;
                txtByLastName.Visible = false;
            }
        }
    }
}
