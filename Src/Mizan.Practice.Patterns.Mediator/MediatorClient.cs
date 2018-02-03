using Mizan.Practice.Patterns.Mediator;
using System;

namespace Mizan.Practice.Patterns.Mediator
{
    public class MediatorClient
    {
        public void Test()
        {
            IMessageSender messageSender = new MessageSender();

            var user1 = new User
            {
                Email = "user1@email",
                Name = "User 1"
            };

            var user2 = new User
            {
                Email = "user2@email",
                Name = "User 2"
            };

            messageSender.Register(user1);
            messageSender.Register(user2);

            user1.Send(user2, "Hello user2!!");
        }
    }
}
