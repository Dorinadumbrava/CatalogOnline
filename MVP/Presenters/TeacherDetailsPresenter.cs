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
    public class TeacherDetailsPresenter : IPresenter, ISubscriber<LoginSuccessMessage>
    {

        //public IEventAgregator /*eventAgregator*/ { get; }
        public ITeacherDetailsView TeacherDetailsView { get; }

        private StupidTeacherService stupidTeacherService;
        private string teacherUsername;
        private readonly IApplicationController controller;

        public TeacherDetailsPresenter(ITeacherDetailsView teacherDetailsView, IApplicationController controller)
        {
            //this.eventAgregator = eventAgregator;
            TeacherDetailsView = teacherDetailsView;
            this.controller = controller;
            EventAgregator.Instance.Subscribe<LoginSuccessMessage>(OnEventHandler);
        }


        public void OnEventHandler(LoginSuccessMessage message)
        {
            teacherUsername = message._username;
            var teacher = stupidTeacherService.GetMockTeacherDetails(teacherUsername);
            TeacherDetailsView.SetTeacherName(teacher.Name);
            TeacherDetailsView.SetTeacherSurname(teacher.Surname);
            TeacherDetailsView.SetTeacherGrade(teacher.Grade);
        }

        public void Run()
        {
            TeacherDetailsView.Show();
        }
    }
}
