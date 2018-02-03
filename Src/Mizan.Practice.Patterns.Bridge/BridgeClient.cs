using Mizan.Practice.Patterns.Bridge.Abstraction;
using Mizan.Practice.Patterns.Bridge.Implementor;
using System;

namespace Mizan.Practice.Patterns.Bridge
{
    public class BridgeClient
    {
        public void Test()
        {
            Message emailMessage = new EmailMessage();
            emailMessage.MessageSender = new EmailSender();
            emailMessage.Send();
            Console.ReadKey();
        }
    }
}
