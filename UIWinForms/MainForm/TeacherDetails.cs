using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Views.Views.Interfaces;

namespace UIWinForms
{
    public partial class TeacherDetails : MetroFramework.Controls.MetroUserControl, ITeacherDetailsView
    {

        public TeacherDetails()
        {
            InitializeComponent();
        }

        public void SetTeacherName (string teacherName)
        {
            TeacherNameLbl.Text = teacherName;
        }

        public void SetTeacherSurname(string teacherSurname)
        {
            teacherSurnamelbl.Text = teacherSurname;
        }

        public void SetTeacherGrade(string teacherGrade)
        {
            teacherGradelbl.Text = teacherGrade;
        }
    }
}
