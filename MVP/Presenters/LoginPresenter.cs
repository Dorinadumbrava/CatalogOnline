using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
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
        private readonly IApplicationController controller;

        //private readonly IEventAgregator _eventAgregator;

        public LoginPresenter(ILoginView view, ILoginService service,
            IApplicationController controller
            //, IEventAgregator eventAgregator
            )
        {
            _view = view;
            _service = service;
            this.controller = controller;
            //_eventAgregator = eventAgregator;
            _view.Login +=  () => Login(_view.Username, _view.Password);
        }

        public void Run()
        {
            _view.Show();
        }

        private async void Login(string username, string password)
        {
            if (username == null)
                throw new ArgumentException("username", nameof(username));
            if (password == null)
                throw new ArgumentException("password", nameof(password));

            if (await _service.Login(username, password))
            {
                EventAgregator.Instance.Publish(new LoginSuccessMessage(username));
                controller.Run<MainPresenter>();
                
            }
            else
            {
                _view.ShowError("Invalid username or password");
            }
        }
    }
}
