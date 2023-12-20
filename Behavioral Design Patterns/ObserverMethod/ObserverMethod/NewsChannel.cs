using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMethod
{
    public class NewsChannel : IObserver
    {
        private string channelName;

        public NewsChannel(string name)
        {
            channelName = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{channelName} received news: {message}");
        }
    }
}
