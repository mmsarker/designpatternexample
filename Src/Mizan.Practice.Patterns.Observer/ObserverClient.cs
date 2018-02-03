using Mizan.Practice.Patterns.Observer.ConcreteObserver;
using Mizan.Practice.Patterns.Observer.Observer;
using System;

namespace Mizan.Practice.Patterns.Observer
{
    public class ObserverClient
    {
        public void Test()
        {
            NewsFeedGeneratorBase newsFeedGenerator = new NewsFeedGenerator();
            INewsFeedObserver tvNewsFeedObserver = new TelevisionNewsFeedObserver();
            INewsFeedObserver webNewsFeedObserver = new WebNewsFeedObserver();
            newsFeedGenerator.Subscribe(tvNewsFeedObserver);
            newsFeedGenerator.Subscribe(webNewsFeedObserver);
            newsFeedGenerator.ProcessNewsFeed();
        }
    }
}
