namespace CA_10389618
{
    partial class View_all_students
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
            this.components = new System.ComponentModel.Container();
            this.dgAllStudents = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllStudents
            // 
            this.dgAllStudents.AllowUserToAddRows = false;
            this.dgAllStudents.AllowUserToDeleteRows = false;
            this.dgAllStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllStudents.Location = new System.Drawing.Point(14, 39);
            this.dgAllStudents.Name = "dgAllStudents";
            this.dgAllStudents.ReadOnly = true;
            this.dgAllStudents.Size = new System.Drawing.Size(1014, 256);
            this.dgAllStudents.TabIndex = 0;
            this.dgAllStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllStudents_CellClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(CA_10389618.Person);
            // 
            // View_all_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1042, 309);
            this.Controls.Add(this.dgAllStudents);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "View_all_students";
            this.Text = "View All Students";
            this.Controls.SetChildIndex(this.dgAllStudents, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgAllStudents;
        protected System.Windows.Forms.BindingSource studentBindingSource;
    }
}