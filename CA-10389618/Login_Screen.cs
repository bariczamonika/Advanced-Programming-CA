using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CA_10389618
{
    public partial class Login_Screen : Menu
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("User name must be filled in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password must be filled in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                }
            
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            studentToolStripMenuItem.Visible = false;
            courseToolStripMenuItem.Visible = false;
            teacherToolStripMenuItem.Visible = false;
            saveAsToolStripMenuItem.Visible = false;
            saveToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            gbStudentDialog.Visible = false;
        }
    }
}
