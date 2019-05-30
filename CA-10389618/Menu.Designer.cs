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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.teacherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
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
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewCourseToolStripMenuItem.Text = "View Course";
            // 
            // viewDatabaseHistoryToolStripMenuItem1
            // 
            this.viewDatabaseHistoryToolStripMenuItem1.Name = "viewDatabaseHistoryToolStripMenuItem1";
            this.viewDatabaseHistoryToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem1.Text = "View Database History";
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
            // 
            // editTeacherToolStripMenuItem
            // 
            this.editTeacherToolStripMenuItem.Name = "editTeacherToolStripMenuItem";
            this.editTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editTeacherToolStripMenuItem.Text = "Edit Teacher";
            // 
            // deleteTeacherToolStripMenuItem
            // 
            this.deleteTeacherToolStripMenuItem.Name = "deleteTeacherToolStripMenuItem";
            this.deleteTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteTeacherToolStripMenuItem.Text = "Delete Teacher";
            // 
            // viewTeacherToolStripMenuItem
            // 
            this.viewTeacherToolStripMenuItem.Name = "viewTeacherToolStripMenuItem";
            this.viewTeacherToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewTeacherToolStripMenuItem.Text = "View Teacher";
            // 
            // viewDatabaseHistoryToolStripMenuItem2
            // 
            this.viewDatabaseHistoryToolStripMenuItem2.Name = "viewDatabaseHistoryToolStripMenuItem2";
            this.viewDatabaseHistoryToolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem2.Text = "View Database History";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
    }
}

