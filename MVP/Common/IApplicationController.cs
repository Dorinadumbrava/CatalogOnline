using MVP.Presenters.Presenters.Interfaces;
using MVP.Views.ControlInterfaces;
using MVP.Views.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Common
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterControlView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IControlView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance);

        IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;
    }
}
