using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Bridge.Implementor
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
