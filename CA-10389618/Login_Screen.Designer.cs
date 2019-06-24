namespace CA_10389618
{
    partial class Login_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnFillUsers = new System.Windows.Forms.Button();
            this.btnClearUsers = new System.Windows.Forms.Button();
            this.btnShowUsersAndPasswords = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Picture source: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(126, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(126, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnFillUsers
            // 
            this.btnFillUsers.Location = new System.Drawing.Point(16, 240);
            this.btnFillUsers.Name = "btnFillUsers";
            this.btnFillUsers.Size = new System.Drawing.Size(145, 23);
            this.btnFillUsers.TabIndex = 9;
            this.btnFillUsers.Text = "Fill up user table inDB";
            this.btnFillUsers.UseVisualStyleBackColor = true;
            this.btnFillUsers.Click += new System.EventHandler(this.btnFillUsers_Click);
            // 
            // btnClearUsers
            // 
            this.btnClearUsers.Location = new System.Drawing.Point(167, 240);
            this.btnClearUsers.Name = "btnClearUsers";
            this.btnClearUsers.Size = new System.Drawing.Size(145, 23);
            this.btnClearUsers.TabIndex = 10;
            this.btnClearUsers.Text = "Clear user table in DB";
            this.btnClearUsers.UseVisualStyleBackColor = true;
            this.btnClearUsers.Click += new System.EventHandler(this.btnClearUsers_Click);
            // 
            // btnShowUsersAndPasswords
            // 
            this.btnShowUsersAndPasswords.Location = new System.Drawing.Point(318, 240);
            this.btnShowUsersAndPasswords.Name = "btnShowUsersAndPasswords";
            this.btnShowUsersAndPasswords.Size = new System.Drawing.Size(145, 23);
            this.btnShowUsersAndPasswords.TabIndex = 11;
            this.btnShowUsersAndPasswords.Text = "Show users ";
            this.btnShowUsersAndPasswords.UseVisualStyleBackColor = true;
            this.btnShowUsersAndPasswords.Click += new System.EventHandler(this.btnShowUsersAndPasswords_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CA_10389618.Properties.Resources.shutterstock_573831559_resized_1;
            this.pictureBox1.Location = new System.Drawing.Point(277, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(466, 266);
            this.Controls.Add(this.btnShowUsersAndPasswords);
            this.Controls.Add(this.btnClearUsers);
            this.Controls.Add(this.btnFillUsers);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Login_Screen";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Login_Screen_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnFillUsers, 0);
            this.Controls.SetChildIndex(this.btnClearUsers, 0);
            this.Controls.SetChildIndex(this.btnShowUsersAndPasswords, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnFillUsers;
        private System.Windows.Forms.Button btnClearUsers;
        private System.Windows.Forms.Button btnShowUsersAndPasswords;
    }
}