using MVP.Events.EventInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Events
{
    public class LoginSuccessMessage : IApplicationEvent
    {
        public string _username { get; private set; }
        public LoginSuccessMessage(string username)
        {
            _username = username;
        }
    }
}
