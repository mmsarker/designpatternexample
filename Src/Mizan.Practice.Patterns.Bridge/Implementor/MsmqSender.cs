using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Bridge.Implementor
{
    public class MsmqSender : IMessageSender
    {        
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ sender is sending message");
        }
    }
}
