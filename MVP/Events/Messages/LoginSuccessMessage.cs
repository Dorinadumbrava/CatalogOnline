using MVP.Events.EventInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Events.Messages
{
    public class LoginSuccessMessage : IMessage
    {
        public string Username { get; set; }
    }
}
