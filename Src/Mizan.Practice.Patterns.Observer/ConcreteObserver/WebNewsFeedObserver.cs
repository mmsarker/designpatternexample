using Mizan.Practice.Patterns.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Observer.ConcreteObserver
{
    public class WebNewsFeedObserver : INewsFeedObserver
    {
        public void UpdateNews()
        {
            Console.WriteLine("Web news feed processor updating news feed...");
        }
    }
}
