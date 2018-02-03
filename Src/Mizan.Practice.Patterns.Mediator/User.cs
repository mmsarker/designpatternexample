using Mizan.Practice.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Mediator
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public IMessageSender messageSender { get; set; }
        public void Send(User to, string message)
        {
            Console.WriteLine($"Sending message to user {to.Name}");
            System.Threading.Thread.Sleep(2000);
            messageSender.SendMessage(message, this, to);
        }

        public void Receive(string mesage, User from)
        {
            Console.WriteLine($"{this.Name} received message from user {from.Name}");
        }

    }
}
