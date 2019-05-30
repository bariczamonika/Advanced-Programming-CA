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
        public FindInDB()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtByID.Text != "")
            {

                dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student WHERE StudentID=@StudentID", "StudentID", int.Parse(txtByID.Text));
                /*  SqlConnection conn=EstablishConnection();
                  try
                  {
                      if (conn.State==ConnectionState.Closed || conn.State==ConnectionState.Broken)
                      {
                          conn.Open();
                          string stmt1 = "SELECT * FROM Student WHERE StudentID=@StudentID";
                          int.TryParse(txtByID.Text, out int k);
                          SqlDataAdapter sqlDA = new SqlDataAdapter(stmt1,conn);
                          sqlDA.SelectCommand.Parameters.AddWithValue("@StudentID", k);
                          DataTable dtbl = new DataTable();
                          sqlDA.Fill(dtbl);
                          dgStudent.DataSource = dtbl;
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
                  }*/
            }
            else if (txtByFirstName.Text != "")
            {
                string k = '%' + txtByFirstName.Text + '%';
                dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student WHERE FirstName LIKE @FirstName", "FirstName", k);
                /*
                SqlConnection conn = EstablishConnection();
                try
                {
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    {
                        conn.Open();
                        string stmt1 = "SELECT * FROM Student WHERE FirstName LIKE @FirstName";
                        SqlDataAdapter sqlDA = new SqlDataAdapter(stmt1, conn);
                        string k = '%'+txtByFirstName.Text + '%';
                        sqlDA.SelectCommand.Parameters.AddWithValue("@FirstName", k);
                        DataTable dtbl = new DataTable();
                        sqlDA.Fill(dtbl);
                        dgStudent.DataSource = dtbl;
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
                }*/
            }
            else if (txtByLastName.Text != "")
                //NOT WORKING FOR WHATEVER REASON
            {
                string k = '%' + txtByLastName.Text + '%';
                dgStudent.DataSource = UseDBWithDataTable("SELECT * FROM Student WHERE LastName LIKE @LastName", "LastName", k);
                /*
                SqlConnection conn = EstablishConnection();
                try
                {
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    {
                        conn.Open();
                        string stmt1 = "SELECT * FROM Student WHERE LastName=@LastName";
                        string k = '%'+txtByLastName.Text + '%';
                        SqlDataAdapter sqlDA = new SqlDataAdapter(stmt1, conn);
                        sqlDA.SelectCommand.Parameters.AddWithValue("@LastName", k);
                        DataTable dtbl = new DataTable();
                        sqlDA.Fill(dtbl);
                        dgStudent.DataSource = dtbl;
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
            }*/
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
            if (dgStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgStudent.CurrentRow.Selected = true;
                string ID = dgStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                int.TryParse(ID, out int SID);
                this.Close();
                EditStudent es = new EditStudent(SID);
                es.Show();
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
    }
}
