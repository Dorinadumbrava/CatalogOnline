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
        public LoginForm(ApplicationContext context)
        {
            _context = context;
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

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
