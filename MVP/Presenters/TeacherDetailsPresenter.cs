using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
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
    public class TeacherDetailsPresenter : IPresenter, ISubscriber<LoginSuccessMessage>
    {

        //public IEventAgregator /*eventAgregator*/ { get; }
        public ITeacherDetailsView TeacherDetailsView { get; }

        private string teacherUsername;
        private readonly IApplicationController controller;
        private readonly ITeacherService _teacherService;

        public TeacherDetailsPresenter(ITeacherDetailsView teacherDetailsView, IApplicationController controller, ITeacherService teacherService)
        {
            //this.eventAgregator = eventAgregator;
            TeacherDetailsView = teacherDetailsView;
            this.controller = controller;
            _teacherService = teacherService;
            EventAgregator.Instance.Subscribe<LoginSuccessMessage>(OnEventHandler);
        }


        public async void OnEventHandler(LoginSuccessMessage message)
        {
            teacherUsername = message._username;
            var teacher = await _teacherService.GetTeacherDetails(teacherUsername);
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
