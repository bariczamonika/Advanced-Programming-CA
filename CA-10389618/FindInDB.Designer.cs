namespace CA_10389618
{
    partial class FindInDB
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtByID = new System.Windows.Forms.TextBox();
            this.txtByFirstName = new System.Windows.Forms.TextBox();
            this.txtByLastName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find by First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Find by Last Name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(119, 112);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(136, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtByID
            // 
            this.txtByID.Location = new System.Drawing.Point(119, 34);
            this.txtByID.Name = "txtByID";
            this.txtByID.Size = new System.Drawing.Size(298, 20);
            this.txtByID.TabIndex = 1;
            this.txtByID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtByID_KeyDown);
            // 
            // txtByFirstName
            // 
            this.txtByFirstName.Location = new System.Drawing.Point(119, 60);
            this.txtByFirstName.Name = "txtByFirstName";
            this.txtByFirstName.Size = new System.Drawing.Size(298, 20);
            this.txtByFirstName.TabIndex = 2;
            this.txtByFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtByFirstName_KeyDown);
            // 
            // txtByLastName
            // 
            this.txtByLastName.Location = new System.Drawing.Point(119, 86);
            this.txtByLastName.Name = "txtByLastName";
            this.txtByLastName.Size = new System.Drawing.Size(298, 20);
            this.txtByLastName.TabIndex = 3;
            this.txtByLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtByLastName_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.AllowUserToAddRows = false;
            this.dgStudent.AllowUserToDeleteRows = false;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(15, 167);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.Size = new System.Drawing.Size(810, 150);
            this.dgStudent.TabIndex = 6;
            this.dgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgStudent_CellClick);
            // 
            // FindInDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 318);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtByLastName);
            this.Controls.Add(this.txtByFirstName);
            this.Controls.Add(this.txtByID);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindInDB";
            this.Text = "Find Student";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.txtByID, 0);
            this.Controls.SetChildIndex(this.txtByFirstName, 0);
            this.Controls.SetChildIndex(this.txtByLastName, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dgStudent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtByID;
        private System.Windows.Forms.TextBox txtByFirstName;
        private System.Windows.Forms.TextBox txtByLastName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgStudent;
    }
}