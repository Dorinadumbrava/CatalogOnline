using MVP.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services
{
    public class StupidLoginService : ILoginService
    {
        public bool Login(string username, string password)
        {
            return username == password;
        }
    }
}
