using Mizan.Practice.Patterns.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Observer.ConcreteObserver
{
    public class NewsFeedGenerator : NewsFeedGeneratorBase
    {
        public override void ProcessNewsFeed()
        {
            Console.WriteLine("Processing news feed.....");
            System.Threading.Thread.Sleep(1000);
            this.Notify();
        }
    }
}
