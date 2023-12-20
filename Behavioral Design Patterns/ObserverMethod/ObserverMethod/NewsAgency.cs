using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMethod
{
    // Concrete subject
    public class NewsAgency : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string news;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(news);
            }
        }

        public void SetNews(string news)
        {
            this.news = news;
            NotifyObservers();
        }
    }
}
