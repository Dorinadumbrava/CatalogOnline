using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services.Services.Interfaces
{
    public interface ILoginService
    {
        bool Login(string username, string password);
    }
}
