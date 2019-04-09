using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views.Views.Interfaces
{
    public interface ILoginView : IView
    {
        event Action Login;
        void ShowError(string errorMessage);
    }
}
