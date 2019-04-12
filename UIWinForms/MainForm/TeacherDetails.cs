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
    }
}
