using Mizan.Practice.Patterns.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Observer.ConcreteObserver
{
    public class TelevisionNewsFeedObserver : INewsFeedObserver
    {
        public void UpdateNews()
        {
            Console.WriteLine("TV news feed processor updating news feed...");
        }
    }
}
