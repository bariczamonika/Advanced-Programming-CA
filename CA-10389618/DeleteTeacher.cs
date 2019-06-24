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
    public partial class DeleteTeacher : Person
    {
        public DeleteTeacher(int ID)
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HitCancelButton();
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
                    //delete from all tables TODO
                    string stmt = "DELETE FROM Teacher WHERE TeacherID=@TeacherID";
                    string stmt1 = "DELETE c FROM Course c INNER JOIN Teacher t ON c.TeacherID=t.TeacherID " +
                        "WHERE c.TeacherID=@TeacherID;";
                    string stmt2 = "DELETE c FROM CourseManagement c INNER JOIN Course cc ON " +
                        "c.CourseID=cc.CourseID WHERE cc.TeacherID=@TeacherID;";
    
                    SqlCommand cmd2 = new SqlCommand(stmt2, conn);
                    SqlCommand cmd1 = new SqlCommand(stmt1, conn);
                    SqlCommand cmd = new SqlCommand(stmt, conn);
                    cmd2.Parameters.AddWithValue("@TeacherID", txtStudentID.Text);
                    cmd2.ExecuteNonQuery();
                    cmd1.Parameters.AddWithValue("@TeacherID", txtStudentID.Text);
                    cmd1.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("@TeacherID", txtStudentID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher deleted");
                    this.Close();
                    MainScreen m = new MainScreen();
                    m.Show();
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
