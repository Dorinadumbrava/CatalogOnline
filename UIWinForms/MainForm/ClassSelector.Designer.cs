namespace UIWinForms
{
    partial class ClassSelector
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
            this.ClassLabel = new MetroFramework.Controls.MetroLabel();
            this.DisciplineLabel = new MetroFramework.Controls.MetroLabel();
            this.Disciplines = new MetroFramework.Controls.MetroComboBox();
            this.Classes = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // ClassLabel
            // 
            this.ClassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ClassLabel.Location = new System.Drawing.Point(39, 125);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(81, 20);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Select Class";
            // 
            // DisciplineLabel
            // 
            this.DisciplineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisciplineLabel.AutoSize = true;
            this.DisciplineLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DisciplineLabel.Location = new System.Drawing.Point(39, 28);
            this.DisciplineLabel.Name = "DisciplineLabel";
            this.DisciplineLabel.Size = new System.Drawing.Size(109, 20);
            this.DisciplineLabel.TabIndex = 1;
            this.DisciplineLabel.Text = "Select Discipline";
            // 
            // Disciplines
            // 
            this.Disciplines.FormattingEnabled = true;
            this.Disciplines.ItemHeight = 24;
            this.Disciplines.Location = new System.Drawing.Point(39, 63);
            this.Disciplines.Name = "Disciplines";
            this.Disciplines.Size = new System.Drawing.Size(121, 30);
            this.Disciplines.TabIndex = 2;
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.ItemHeight = 24;
            this.Classes.Location = new System.Drawing.Point(39, 162);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(121, 30);
            this.Classes.TabIndex = 3;
            // 
            // ClassSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.Disciplines);
            this.Controls.Add(this.DisciplineLabel);
            this.Controls.Add(this.ClassLabel);
            this.Name = "ClassSelector";
            this.Size = new System.Drawing.Size(191, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ClassLabel;
        private MetroFramework.Controls.MetroLabel DisciplineLabel;
        private MetroFramework.Controls.MetroComboBox Disciplines;
        private MetroFramework.Controls.MetroComboBox Classes;
    }
}
