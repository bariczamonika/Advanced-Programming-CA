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
    public partial class ViewAllCourses : Menu
    {
        public ViewAllCourses()
        {
            InitializeComponent();
            dgAllCourses.DataSource = UseDBWithDataTable("SELECT Course.CourseID AS \"Course ID\", " +
                "Course.CourseName AS \"Course name\", " +
                "Teacher.FirstName +' '+ Teacher.LastName AS \"Teacher's name\" FROM Course  " +
                "INNER JOIN Teacher  ON Course.TeacherID=Teacher.TeacherID", "", "");

        }

        private void dgAllCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAllCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgAllCourses.CurrentRow.Selected = true;
                    string ID = dgAllCourses.Rows[e.RowIndex].Cells["CourseID"].FormattedValue.ToString();
                    int.TryParse(ID, out int SID);
                    this.Close();
                    ViewCourse vs = new ViewCourse(SID);
                    vs.Show();
                }
            }
            catch { MessageBox.Show("Wrong cell has been clicked"); }
        }
    }
}
