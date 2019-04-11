using MVP.ViewModel;
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

namespace UIWinForms
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm, ILoginView
    {
        private readonly ApplicationContext _context;
        private readonly IClassSelectorView _classSelector;
        private readonly ITeacherDetailsView _teacherDetailsView;

        public LoginForm(ApplicationContext context, IClassSelectorView classSelector, ITeacherDetailsView teacherDetailsView)
        {
            _context = context;
            _classSelector = classSelector;
            _teacherDetailsView = teacherDetailsView;
            InitializeComponent();

            btnLogin.Click += (sender, args) => Invoke(Login);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }
        public string Username { get { return txtUsername.Text; } }
        public string Password { get { return txtPassword.Text; } }
        public event Action Login;

        public void ShowError(string errorMessage)
        {
            lblError.Text = errorMessage;
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public void OpenMainForm()
        {
            MainForm mf = new MainForm(_teacherDetailsView, _classSelector, _context);
            mf.Show();
        }
    }
}
