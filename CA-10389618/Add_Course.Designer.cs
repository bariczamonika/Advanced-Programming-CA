namespace CA_10389618
{
    partial class Add_Course
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
            this.SuspendLayout();
            // 
            // rtbCourseDescription
            // 
            this.rtbCourseDescription.Size = new System.Drawing.Size(245, 145);
            // 
            // cbTeacher
            // 
            this.cbTeacher.Size = new System.Drawing.Size(245, 23);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(679, 376);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Add_Course";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}