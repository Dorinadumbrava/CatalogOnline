using MVP.Services.Services.Interfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters.Presenters.Interfaces
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginService _service;

        public LoginPresenter(ILoginView view, ILoginService service)
        {
            _view = view;
            _service = service;

            _view.Login += () => Login(_view.Username, _view.Password);
        }

        public void Run()
        {
            _view.Show();
        }

        private void Login(string username, string password)
        {
            if (username == null)
                throw new ArgumentException("username", nameof(username));
            if (password == null)
                throw new ArgumentException("password", nameof(password));

            if (!_service.Login(username, password))
            {
                _view.ShowError("Invalid username or password");
            }
            else
            {
                //Net view after Login
            }
        }
    }
}
