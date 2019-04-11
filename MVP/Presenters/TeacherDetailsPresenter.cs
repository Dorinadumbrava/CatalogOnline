using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
using MVP.Events.Messages;
using MVP.Presenters.Presenters.Interfaces;
using MVP.Services;
using MVP.Services.Services.Interfaces;
using MVP.ViewModel;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class TeacherDetailsPresenter : IPresenter
    {

        public IEventAggregator eventAgregator { get; }
        public ITeacherDetailsView TeacherDetailsView { get; }

        private string teacherUsername;
        private readonly IApplicationController controller;
        private readonly ITeacherService teacherService;

        public TeacherDetailsPresenter(ITeacherDetailsView teacherDetailsView, IApplicationController controller,
            IEventAggregator eventAggregator, ITeacherService teacherService)
        {
            TeacherDetailsView = teacherDetailsView;
            this.controller = controller;
            this.teacherService = teacherService;
            this.eventAgregator = eventAggregator;
            Action<LoginSuccessMessage> loginSuccessMessage = message => { OnEventHandler(message); };
            var subscription = this.eventAgregator.Subscribe(loginSuccessMessage);
        }


        public async void OnEventHandler(LoginSuccessMessage message)
        {
            teacherUsername = message.Username;
            var teacher = await teacherService.GetTeacherDetails(teacherUsername);
            TeacherDetailsView.SetTeacherName(teacher.FirstName);
            TeacherDetailsView.SetTeacherSurname(teacher.Surname);
            TeacherDetailsView.SetTeacherGrade(teacher.Degree);
        }

        public void Run()
        {
            TeacherDetailsView.Show();
        }
    }
}
