using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_10389618
{
    public partial class MainScreen : Menu
    {
       
        public MainScreen()
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
            string stmt = "SELECT Student.StudentID, Student.FirstName, Student.LastName, Student.Level, " +
                    "Course.CourseName, CourseManagement.Cost, " +
                    "Teacher.FirstName + ' ' + Teacher.Lastname AS \"Teacher's name\"" +
                    "FROM (((Student " +
                    "LEFT JOIN CourseManagement ON Student.StudentID=CourseManagement.StudentID)" +
                    "LEFT JOIN Course ON Course.CourseID=CourseManagement.CourseID)" +
                    "LEFT JOIN Teacher ON Teacher.TeacherID=Course.TeacherID)";
            dgvInfo.DataSource = UseDBWithDataTable(stmt, "", "");

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
