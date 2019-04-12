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
        private readonly IEventAggregator _eventAggregator;
        private readonly ITeacherDetailsView teacherDetailsView;
        //private string teacherUsername { get; set; }

        public MainPresenter(IMainView mainView, IApplicationController controller, 
            ITeacherService teacherService, IEventAggregator eventAggregator) 
        {
            _mainView = mainView;
            this.teacherService = teacherService;
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            Run();
            
        }
        public async Task HandleAsync(LoginSuccessMessage message, CancellationToken cancellationToken)
        {
            var teacherUsername = message.Username;
            SetTeacherName(teacherUsername);

        }

        public IApplicationController Controller { get; }

        public void Run()
        {
            _mainView.Open();
        }

        public async Task SetTeacherName(string username)
        {
            var teacher = await teacherService.GetTeacherDetails(username);
            _mainView.TeacherName = teacher.FirstName;
            _mainView.TeacherSurname = teacher.Surname;
            _mainView.TeacherGrade = teacher.Degree;
        }

    }
}
