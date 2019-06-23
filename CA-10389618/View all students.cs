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
    public partial class View_all_students : Menu
    {
        public View_all_students()
        {
            InitializeComponent();
      
            dgAllStudents.DataSource = UseDBWithDataTable("SELECT * FROM Student", "", "");
        }

        private void dgAllStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAllStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgAllStudents.CurrentRow.Selected = true;
                    string ID = dgAllStudents.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                    int.TryParse(ID, out int SID);
                    this.Close();
                    ViewStudent vs = new ViewStudent(SID);
                    vs.Show();
                }
            }
            catch 
            {
                MessageBox.Show("Wrong cell has been clicked");
            }
        }
    }
}
