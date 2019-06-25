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
    public partial class ViewTeacher : Person
    {
        public ViewTeacher(int ID)
        {
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
            }
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedTeacher(ID);
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
    }
}
