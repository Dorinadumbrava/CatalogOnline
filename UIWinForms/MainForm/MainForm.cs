using MVP.Views.ControlInterfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinForms.MainForm
{
    public partial class MainForm : Form, IMainView
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public string TeacherName { get { return teacherDetails1.TeacherName; } set { teacherDetails1.TeacherName = value; } }

    }
}
