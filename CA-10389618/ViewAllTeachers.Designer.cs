namespace CA_10389618
{
    partial class ViewAllTeachers
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
            this.dgAllTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllTeachers
            // 
            this.dgAllTeachers.AllowUserToAddRows = false;
            this.dgAllTeachers.AllowUserToDeleteRows = false;
            this.dgAllTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgAllTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllTeachers.Location = new System.Drawing.Point(27, 58);
            this.dgAllTeachers.Name = "dgAllTeachers";
            this.dgAllTeachers.ReadOnly = true;
            this.dgAllTeachers.Size = new System.Drawing.Size(623, 225);
            this.dgAllTeachers.TabIndex = 1;
            this.dgAllTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllTeachers_CellClick);
            // 
            // ViewAllTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(664, 309);
            this.Controls.Add(this.dgAllTeachers);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ViewAllTeachers";
            this.Text = "View All Teachers";
            this.Controls.SetChildIndex(this.dgAllTeachers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgAllTeachers;
    }
}