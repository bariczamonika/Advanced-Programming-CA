namespace CA_10389618
{
    partial class ViewAllCourses
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
            this.dgAllCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllCourses
            // 
            this.dgAllCourses.AllowUserToAddRows = false;
            this.dgAllCourses.AllowUserToDeleteRows = false;
            this.dgAllCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllCourses.Location = new System.Drawing.Point(15, 59);
            this.dgAllCourses.Name = "dgAllCourses";
            this.dgAllCourses.ReadOnly = true;
            this.dgAllCourses.Size = new System.Drawing.Size(682, 290);
            this.dgAllCourses.TabIndex = 1;
            this.dgAllCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllCourses_CellClick);
            // 
            // ViewAllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 519);
            this.Controls.Add(this.dgAllCourses);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ViewAllCourses";
            this.Text = "View All Courses";
            this.Controls.SetChildIndex(this.dgAllCourses, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgAllCourses;
    }
}