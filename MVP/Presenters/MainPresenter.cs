using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
using MVP.Events.Messages;
using MVP.Presenters.Presenters.Interfaces;
using MVP.Services;
using MVP.Services.Services.Interfaces;
using MVP.ViewModel;
using MVP.Views.ControlInterfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class MainPresenter : IMainPresenter, IHandle<LoginSuccessMessage>
    {
        private IMainView _mainView;
        private readonly ITeacherService teacherService;
        private readonly IEventAggregator eventAggregator;
        private readonly ITeacherDetailsView teacherDetailsView;
        private string teacherUsername;

        public MainPresenter(IMainView mainView, IApplicationController controller, 
            ITeacherService teacherService, IEventAggregator eventAggregator) 
        {
            _mainView = mainView;
            this.teacherService = teacherService;
            this.eventAggregator = eventAggregator;
            var message = new LoginSuccessMessage();
            //Action<LoginSuccessMessage> loginSuccessMessage = message => { _ = HandleAsync(message, CancellationToken.None); };
            //this.eventAggregator.SubscribeOnPublishedThread(loginSuccessMessage);
            this.eventAggregator.Subscribe(message, f => (HandleAsync(message, CancellationToken.None)));
            SetTeacherName();
            Run();
        }
        public async Task HandleAsync(LoginSuccessMessage message, CancellationToken cancellationToken)
        {
            teacherUsername = message.Username;
            var teacher = await teacherService.GetTeacherDetails(teacherUsername);
        }

        public IApplicationController Controller { get; }

        public void Run()
        {
            _mainView.Show();
        }

        void SetTeacherName()
        {
            _mainView.TeacherName = teacherUsername;
        }

    }
}
