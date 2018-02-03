using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Bridge.Abstraction
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            this.MessageSender.SendMessage(this.Subject, this.Body);
        }
    }
}
