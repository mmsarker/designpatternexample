using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Bridge.Implementor
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web service sender is sending message");
        }
    }
}
