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
    public partial class ViewAllTeachers : Menu
    {
        public ViewAllTeachers()
        {
            InitializeComponent();
            dgAllTeachers.DataSource = UseDBWithDataTable("SELECT * FROM Teacher", "", "");
        }

        private void dgAllTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAllTeachers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgAllTeachers.CurrentRow.Selected = true;
                    string ID = dgAllTeachers.Rows[e.RowIndex].Cells["TeacherID"].FormattedValue.ToString();
                    int.TryParse(ID, out int SID);
                    this.Close();
                    ViewTeacher vs = new ViewTeacher(SID);
                    vs.Show();
                }
            }
            catch { MessageBox.Show("Wrong cell has been clicked"); }
        }
    }
}
