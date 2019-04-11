using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
using MVP.Presenters.Presenters.Interfaces;
using MVP.Services;
using MVP.ViewModel;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class MainPresenter : IMainPresenter 
    {
        private IMainView _mainView;

        public MainPresenter(IMainView mainView, IApplicationController controller) 
        {
            _mainView = mainView;
            Controller = controller;
            Controller.Run<TeacherDetailsPresenter>();
            Run();
        }

        public IApplicationController Controller { get; }

        public void Run()
        {
            _mainView.Show();
        }

        

    }
}
