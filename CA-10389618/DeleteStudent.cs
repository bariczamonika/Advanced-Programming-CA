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
    public partial class DeleteStudent : Person
    {
        public DeleteStudent(int ID )
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedStudent(ID);
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
                    string stmt = "DELETE FROM CourseManagement WHERE StudentID=@StudentID";
                    string stmt1 = "DELETE FROM Student WHERE StudentID=@StudentID;";
                    SqlCommand cmd = new SqlCommand(stmt, conn);
                    SqlCommand cmd1 = new SqlCommand(stmt1, conn);
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd.ExecuteNonQuery();
                    cmd1.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Student deleted");
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
