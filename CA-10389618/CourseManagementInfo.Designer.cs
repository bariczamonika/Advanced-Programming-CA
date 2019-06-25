namespace CA_10389618
{
    partial class CourseManagementInfo
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCourseManInfo = new System.Windows.Forms.DataGridView();
            this.txtTotalStudents = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseManInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Location = new System.Drawing.Point(142, 45);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(204, 22);
            this.txtCourseName.TabIndex = 0;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Enabled = false;
            this.txtTeacher.Location = new System.Drawing.Point(583, 45);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(235, 22);
            this.txtTeacher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher\'s name";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(142, 92);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(204, 22);
            this.txtStartDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Location = new System.Drawing.Point(142, 137);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(204, 22);
            this.txtEndDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start date";
            // 
            // dgvCourseManInfo
            // 
            this.dgvCourseManInfo.AllowUserToAddRows = false;
            this.dgvCourseManInfo.AllowUserToDeleteRows = false;
            this.dgvCourseManInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseManInfo.Location = new System.Drawing.Point(19, 200);
            this.dgvCourseManInfo.Name = "dgvCourseManInfo";
            this.dgvCourseManInfo.ReadOnly = true;
            this.dgvCourseManInfo.Size = new System.Drawing.Size(661, 216);
            this.dgvCourseManInfo.TabIndex = 8;
            this.dgvCourseManInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseManInfo_CellClick);
            // 
            // txtTotalStudents
            // 
            this.txtTotalStudents.Enabled = false;
            this.txtTotalStudents.Location = new System.Drawing.Point(583, 92);
            this.txtTotalStudents.Name = "txtTotalStudents";
            this.txtTotalStudents.Size = new System.Drawing.Size(235, 22);
            this.txtTotalStudents.TabIndex = 9;
            // 
            // txtIncome
            // 
            this.txtIncome.Enabled = false;
            this.txtIncome.Location = new System.Drawing.Point(583, 137);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(235, 22);
            this.txtIncome.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total number or Students";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total income";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(142, 174);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 22);
            this.txtCourseID.TabIndex = 15;
            this.txtCourseID.Visible = false;
            // 
            // CourseManagementInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtTotalStudents);
            this.Controls.Add(this.dgvCourseManInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtCourseName);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CourseManagementInfo";
            this.Text = "Course Management Info";
            this.Controls.SetChildIndex(this.txtCourseName, 0);
            this.Controls.SetChildIndex(this.txtTeacher, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtStartDate, 0);
            this.Controls.SetChildIndex(this.txtEndDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dgvCourseManInfo, 0);
            this.Controls.SetChildIndex(this.txtTotalStudents, 0);
            this.Controls.SetChildIndex(this.txtIncome, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txtCourseID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseManInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCourseManInfo;
        private System.Windows.Forms.TextBox txtTotalStudents;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCourseID;
    }
}