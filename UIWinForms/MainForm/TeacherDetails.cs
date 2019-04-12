using System.Windows.Forms;
using MVP.Views.ControlInterfaces;

namespace UIWinForms.MainForm
{
    public partial class TeacherDetails : UserControl, ITeacherDetailsView
    {

        public TeacherDetails()
        {
            InitializeComponent();
        }

        public string TeacherName { get { return label1.Text; } set { label1.Text = value; } }
        public string TeacherSurname { get { return label2.Text; } set { label2.Text = value; } }
        public string TeacherGrade { get { return label3.Text; } set { label3.Text = value; } }
    }
}
