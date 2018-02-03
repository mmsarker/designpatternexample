using Mizan.Practice.Patterns.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Bridge.Abstraction
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }        
        public abstract void Send();
    }
}
