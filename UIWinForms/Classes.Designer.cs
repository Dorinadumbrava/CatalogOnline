namespace UIWinForms
{
    partial class Classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.DisciplineList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Discipline";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Class";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(23, 85);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(121, 24);
            this.ClassList.TabIndex = 4;
            // 
            // DisciplineList
            // 
            this.DisciplineList.FormattingEnabled = true;
            this.DisciplineList.Location = new System.Drawing.Point(23, 168);
            this.DisciplineList.Name = "DisciplineList";
            this.DisciplineList.Size = new System.Drawing.Size(121, 24);
            this.DisciplineList.TabIndex = 5;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisciplineList);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Classes";
            this.Size = new System.Drawing.Size(187, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClassList;
        private System.Windows.Forms.ComboBox DisciplineList;
    }
}
