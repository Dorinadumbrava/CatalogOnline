using MVP.Events;
using MVP.Views.Views.Interfaces;
using System.Threading;
using System.Windows.Forms;

namespace UIWinForms.MainForm
{
    public partial class MainForm : Form, IMainView
    {
        private readonly ApplicationContext context;

        public MainForm(ApplicationContext context)
        {
            SyncContext.SetUIContext(SynchronizationContext.Current);
            InitializeComponent();
            this.context = context;
        }

        public void Open()
        {
            context.MainForm = this;
            Show();
        }

        public string TeacherName { get { return teacherDetails1.TeacherName; } set { teacherDetails1.TeacherName = value; } }

        public string TeacherSurname { get { return teacherDetails1.TeacherSurname; } set { teacherDetails1.TeacherSurname = value; } }
        public string TeacherGrade { get { return teacherDetails1.TeacherGrade; } set { teacherDetails1.TeacherGrade = value; } }
    }
}
