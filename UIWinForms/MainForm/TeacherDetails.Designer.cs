namespace UIWinForms
{
    partial class TeacherDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeacherNameLbl = new MetroFramework.Controls.MetroLabel();
            this.teacherSurnamelbl = new MetroFramework.Controls.MetroLabel();
            this.teacherGradelbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // TeacherNameLbl
            // 
            this.TeacherNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherNameLbl.AutoSize = true;
            this.TeacherNameLbl.CustomForeColor = true;
            this.TeacherNameLbl.Location = new System.Drawing.Point(17, 17);
            this.TeacherNameLbl.Name = "TeacherNameLbl";
            this.TeacherNameLbl.Size = new System.Drawing.Size(0, 0);
            this.TeacherNameLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.TeacherNameLbl.TabIndex = 0;
            // 
            // teacherSurnamelbl
            // 
            this.teacherSurnamelbl.AutoSize = true;
            this.teacherSurnamelbl.Location = new System.Drawing.Point(105, 17);
            this.teacherSurnamelbl.Name = "teacherSurnamelbl";
            this.teacherSurnamelbl.Size = new System.Drawing.Size(0, 0);
            this.teacherSurnamelbl.TabIndex = 1;
            // 
            // teacherGradelbl
            // 
            this.teacherGradelbl.AutoSize = true;
            this.teacherGradelbl.Location = new System.Drawing.Point(17, 54);
            this.teacherGradelbl.Name = "teacherGradelbl";
            this.teacherGradelbl.Size = new System.Drawing.Size(0, 0);
            this.teacherGradelbl.TabIndex = 2;
            // 
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teacherGradelbl);
            this.Controls.Add(this.teacherSurnamelbl);
            this.Controls.Add(this.TeacherNameLbl);
            this.Name = "TeacherDetails";
            this.Size = new System.Drawing.Size(252, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel TeacherNameLbl;
        private MetroFramework.Controls.MetroLabel teacherSurnamelbl;
        private MetroFramework.Controls.MetroLabel teacherGradelbl;
    }
}
