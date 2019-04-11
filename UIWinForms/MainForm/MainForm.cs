using MVP.Views.Views.Interfaces;
using System.Windows.Forms;

namespace UIWinForms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm, IMainView
    {
        private readonly ITeacherDetailsView teacherDetails;
        private readonly IClassSelectorView ClassSelector;
        public MainForm(ITeacherDetailsView teacherDetails, IClassSelectorView ClassSelector)
        {
            InitializeComponent();
            this.teacherDetails = teacherDetails;
            this.ClassSelector = ClassSelector;
            teacherDetails.Show();
            ClassSelector.Show();
            //ShowTeacherDetails();
            //ShowClassSelector();

        }



        public void ShowTeacherDetails()
        {
            teacherDetails.Show();
        }

        public void ShowClassSelector()
        {
            ClassSelector.Show();
        }
    }
}