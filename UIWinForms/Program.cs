using Domain;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
using MVP.Presenters.Presenters.Interfaces;
using MVP.Services;
using MVP.Services.Services.Interfaces;
using MVP.Views.ControlInterfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Windows.Forms;
using UIWinForms.MainForm;

namespace UIWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterService<ICatalogContext, CatalogContext>()
                .RegisterService<ITeacherRepository, TeacherRepository>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterServiceSingleton<ITeacherDetailsView, TeacherDetails>()
                .RegisterView<IMainView, UIWinForms.MainForm.MainForm>()
                .RegisterService<ITeacherService, TeacherService>()
                .RegisterServiceSingleton<IEventAggregator, EventAggregator>()
                .RegisterInstance(new ApplicationContext());
            

            controller.Run<LoginPresenter>();
        }
    }
}
