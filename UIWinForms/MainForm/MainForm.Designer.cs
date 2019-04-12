namespace UIWinForms.MainForm
{
    partial class MainForm
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
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.DetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.teacherDetails1 = new UIWinForms.MainForm.TeacherDetails();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.DetailsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.DetailsTable);
            this.MainContainer.Size = new System.Drawing.Size(800, 450);
            this.MainContainer.SplitterDistance = 266;
            this.MainContainer.TabIndex = 0;
            // 
            // DetailsTable
            // 
            this.DetailsTable.ColumnCount = 1;
            this.DetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTable.Controls.Add(this.teacherDetails1, 0, 0);
            this.DetailsTable.Location = new System.Drawing.Point(3, 3);
            this.DetailsTable.Name = "DetailsTable";
            this.DetailsTable.RowCount = 2;
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.31991F));
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.68009F));
            this.DetailsTable.Size = new System.Drawing.Size(267, 447);
            this.DetailsTable.TabIndex = 0;
            // 
            // teacherDetails1
            // 
            this.teacherDetails1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teacherDetails1.Location = new System.Drawing.Point(3, 3);
            this.teacherDetails1.Name = "teacherDetails1";
            this.teacherDetails1.Size = new System.Drawing.Size(261, 133);
            this.teacherDetails1.TabIndex = 0;
            this.teacherDetails1.TeacherName = "hello";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.DetailsTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.TableLayoutPanel DetailsTable;
        private TeacherDetails teacherDetails1;
    }
}