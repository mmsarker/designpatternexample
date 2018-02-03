using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Mediator
{
    public interface IMessageSender
    {
        void Register(User user);
        void SendMessage(string message, User from, User to);
    }
}
