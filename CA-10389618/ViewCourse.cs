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
    public partial class ViewCourse : Course
    {
        public ViewCourse(int ID)
        {
            InitializeComponent();
            SqlConnection conn = EstablishConnection();
            try
            {
                RetrieveInfoForSelectedCourse(ID);
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

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSubmit.Visible = false;
        }
    }
}
