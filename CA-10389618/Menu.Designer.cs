namespace CA_10389618
{
    public partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.mainScreenToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // mainScreenToolStripMenuItem
            // 
            this.mainScreenToolStripMenuItem.Name = "mainScreenToolStripMenuItem";
            this.mainScreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainScreenToolStripMenuItem.Text = "Main screen";
            this.mainScreenToolStripMenuItem.Click += new System.EventHandler(this.mainScreenToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.viewStudentToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.deleteCourseToolStripMenuItem,
            this.viewCourseToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem1});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.deleteCourseToolStripMenuItem_Click);
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewCourseToolStripMenuItem.Text = "View Course";
            this.viewCourseToolStripMenuItem.Click += new System.EventHandler(this.viewCourseToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem1
            // 
            this.viewDatabaseHistoryToolStripMenuItem1.Name = "viewDatabaseHistoryToolStripMenuItem1";
            this.viewDatabaseHistoryToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem1.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem1.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherToolStripMenuItem,
            this.editTeacherToolStripMenuItem,
            this.deleteTeacherToolStripMenuItem,
            this.viewTeacherToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem2});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addTeacherToolStripMenuItem.Text = "Add Teacher";
            this.addTeacherToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // editTeacherToolStripMenuItem
            // 
            this.editTeacherToolStripMenuItem.Name = "editTeacherToolStripMenuItem";
            this.editTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editTeacherToolStripMenuItem.Text = "Edit Teacher";
            this.editTeacherToolStripMenuItem.Click += new System.EventHandler(this.editTeacherToolStripMenuItem_Click);
            // 
            // deleteTeacherToolStripMenuItem
            // 
            this.deleteTeacherToolStripMenuItem.Name = "deleteTeacherToolStripMenuItem";
            this.deleteTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteTeacherToolStripMenuItem.Text = "Delete Teacher";
            this.deleteTeacherToolStripMenuItem.Click += new System.EventHandler(this.deleteTeacherToolStripMenuItem_Click);
            // 
            // viewTeacherToolStripMenuItem
            // 
            this.viewTeacherToolStripMenuItem.Name = "viewTeacherToolStripMenuItem";
            this.viewTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewTeacherToolStripMenuItem.Text = "View Teacher";
            this.viewTeacherToolStripMenuItem.Click += new System.EventHandler(this.viewTeacherToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem2
            // 
            this.viewDatabaseHistoryToolStripMenuItem2.Name = "viewDatabaseHistoryToolStripMenuItem2";
            this.viewDatabaseHistoryToolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem2.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem2.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem2_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            this.courseManagementToolStripMenuItem.Click += new System.EventHandler(this.courseManagementToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1015, 519);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem deleteCourseToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewCourseToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem editTeacherToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem deleteTeacherToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewTeacherToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem2;
        protected System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainScreenToolStripMenuItem;
    }
}

