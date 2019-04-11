using MVP.Views.Views.Interfaces;
using System.Windows.Forms;

namespace UIWinForms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm, IMainView
    {
        private readonly ITeacherDetailsView teacherDetails;
        private readonly IClassSelectorView ClassSelector;
        private readonly ApplicationContext _context;

        public MainForm(ITeacherDetailsView teacherDetails, IClassSelectorView ClassSelector, ApplicationContext context)
        {
            InitializeComponent();
            this.teacherDetails = teacherDetails;
            this.ClassSelector = ClassSelector;
            _context = context;
            teacherDetails.Show();
            ClassSelector.Show();
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