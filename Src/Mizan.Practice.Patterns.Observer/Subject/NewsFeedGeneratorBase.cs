using Mizan.Practice.Patterns.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Observer.ConcreteObserver
{
    public abstract class NewsFeedGeneratorBase
    {
        public List<INewsFeedObserver> _newsFeedObserverList = new List<INewsFeedObserver>();

        public void Subscribe(INewsFeedObserver newsFeedObserver)
        {
            this._newsFeedObserverList.Add(newsFeedObserver);
        }

        public void UnSubscribe(INewsFeedObserver newsFeedObserver)
        {
            this._newsFeedObserverList.Remove(newsFeedObserver);
        }

        public abstract void ProcessNewsFeed();
        
        public void Notify()
        {
            Console.WriteLine("Notifying observers...");
            foreach (var observer in _newsFeedObserverList)
            {
                observer.UpdateNews();
            }
        }

    }
}
