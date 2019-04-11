using Domain;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using LightInject;
using MVP.Common;
using MVP.Events;
using MVP.Events.EventInterfaces;
using MVP.Presenters;
using MVP.Presenters.Presenters.Interfaces;
using MVP.Services;
using MVP.Services.Services.Interfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                .RegisterView<IMainView, MainForm>()
                .RegisterControlView<ITeacherDetailsView, TeacherDetails>()
                .RegisterControlView<IClassSelectorView, ClassSelector>()
                .RegisterService<IStupidTeacherService, StupidTeacherService>()
                .RegisterService<IEventAgregator, EventAgregator>()
                .RegisterInstance(new ApplicationContext());
            

            controller.Run<LoginPresenter>();
        }
    }
}
