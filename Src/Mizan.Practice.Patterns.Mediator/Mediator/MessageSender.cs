using Mizan.Practice.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Mediator
{
    public class MessageSender : IMessageSender
    {
        private IList<User> _userList = new List<User>();
        public MessageSender()
        {
        }

        public void Register(User user)
        {
            if(!_userList.Contains(user))
            {
                _userList.Add(user);
                user.messageSender = this;
            }            
        }

        public void SendMessage(string message, User from, User to)
        {
            if (!_userList.Contains(from) || !_userList.Contains(to))
                return;
            to.Receive(message, from);
        }
    }
}
