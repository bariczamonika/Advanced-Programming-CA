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
using System.Security.Cryptography;
using System.Xml;

namespace CA_10389618
{
    public partial class Menu : Form
    {
        public Menu()
        {
            CenterToScreen();
            InitializeComponent();
        }

        //this is a universal method to establish connection with the database
        protected SqlConnection EstablishConnection()
        {
            SqlConnection conn;
            string cs = ConfigurationManager.ConnectionStrings["conn1"].ConnectionString;
            if (cs != null)
            {
                conn = new SqlConnection(cs);
                return conn;
            }
            else
            {
                throw new Exception("Connection string is empty");
            }
        }

        //this is a method to use the database with a datatable. It is a universal method it takes the sql command, the variable is what we are searching by
        // and the object named k is the controller that we are reading it in from
        protected DataTable UseDBWithDataTable(string sqlcmd, string variable, object k)
        {
            DataTable dtbl = new DataTable();
            SqlConnection conn = EstablishConnection();
            try
            {

                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd, conn);
                    variable = '@' + variable;
                    sqlDA.SelectCommand.Parameters.AddWithValue(variable, k);
                    sqlDA.Fill(dtbl);
                }

            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return dtbl;
        }

        protected void HitCancelButton()
        {
            if (MessageBox.Show("Are you sure you would like to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainScreen m = new MainScreen();
                m.Show();
                this.Hide();
            }
        }



        // this is a method to retrieve the next available ID in the database if there is any
        // it will assign IDs to students, teachers, or courses makign sure they are unique. 
        // as per requirement, student IDs are 8 digits long. 
        protected int GetLastID(int action)
        {
            SqlConnection conn = EstablishConnection();
            int k = 0;
            int x = 0;
           
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
                //retrieveing last record of database -- action 1 => searching students
                if (action==1)
                    {
                    x = 9999999;
                    SqlCommand c = new SqlCommand("SELECT StudentID FROM Student ORDER BY StudentID ASC", conn);
                    SqlDataReader reader = c.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        x = 9999999;
                    }
                    while (reader.Read() && (x==k))
                    {
                            int.TryParse(reader[0].ToString(), out k);
                            x++;
                            if (x != k)
                            {
                             x--;
                            }
                    }
                }   
                //action 2 => searching teachers
                else if (action==2)
                {
                    SqlCommand c = new SqlCommand("SELECT TeacherID FROM Teacher ORDER BY TeacherID ASC", conn);
                    SqlDataReader reader = c.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        x = 0;
                    }
                    while (reader.Read() && (x == k))
                    {
                        int.TryParse(reader[0].ToString(), out k);
                        x++;
                        if (x!=k)
                        {
                            x--;
                        }
                    }
                }
                //action 3 => searching courses
                else if (action==3)
                {
                    x = 99;
                    SqlCommand c = new SqlCommand("SELECT CourseID FROM Course ORDER BY CourseID ASC", conn);
                    SqlDataReader reader = c.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        k = 99;
                    }
                    while (reader.Read() && (x == k))
                    {
                        int.TryParse(reader[0].ToString(), out k);
                        x++;
                        if (x != k)
                        {
                            x--;
                        }
                    }
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
            return x;
        }

        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login_Screen fl = new Login_Screen();
                fl.Show();

            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AddStudent fa = new AddStudent();
            fa.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 1; //edit student action
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }





        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 2; //delete student action
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 3; //view student action
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_all_students vas = new View_all_students();
            vas.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void editTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 4; //edit teacher action
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void deleteTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 5; //delete teacher action
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 6;
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllTeachers vat = new ViewAllTeachers();
            vat.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Course ac = new Add_Course();
            ac.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 7;
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 8;
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int action = 9;
            this.Hide();
            FindInDB fdb = new FindInDB(action);
            fdb.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllCourses vac = new ViewAllCourses();
            vac.Show();
        }

        private void courseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManagement cm = new CourseManagement();
            cm.Show();
        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mc = new MainScreen();
            mc.Show();
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveForm is MainScreen)
                {
                    MainScreen ms = new MainScreen();
                    WriteXMLFile(ms.dgvInfo);
                }
                else if (ActiveForm is ViewAllCourses)
                {
                    ViewAllCourses vac = new ViewAllCourses();
                    WriteXMLFile(vac.dgAllCourses);
                }
                else if (ActiveForm is ViewAllTeachers)
                {
                    ViewAllTeachers vat = new ViewAllTeachers();
                    WriteXMLFile(vat.dgAllTeachers);
                }
                else if (ActiveForm is View_all_students)
                {
                    View_all_students vas = new View_all_students();
                    WriteXMLFile(vas.dgAllStudents);
                }
                else
                {
                    throw new Exception("Only data grids can be exported to XML file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void WriteXMLFile(DataGridView dg)
        {
            DataTable dt = (DataTable)dg.DataSource;
            dt.TableName = "MyTable";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dt.WriteXml(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*XmlTextWriter tW = new XmlTextWriter("Myfile.xml", null);
            tW.WriteStartDocument();
            tW.WriteStartElement(dg.rowheader)
            tW.WriteEndDocument();
            tW.Close();*/
        }
    }
}
