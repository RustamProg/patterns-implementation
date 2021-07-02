using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PatternObserver
{
    public class AgeChanger: IEventManager
    {
        private List<IEventListener> _eventListeners = new List<IEventListener>();
        
        public void AddListener(IEventListener listener)
        {
            _eventListeners.Add(listener);
            Console.WriteLine("Listener added");
        }

        public void RemoveListener(IEventListener listener)
        {
            _eventListeners.Remove(listener);
            Console.WriteLine("Listener removed");
        }

        public void NotifyListeners(int age)
        {
            foreach (var listener in _eventListeners)
            {
                listener.Update(age);
            }
        }

        public void SkipYears(int years)
        {
            Console.WriteLine($"\nSkipping {years} years...\n");
            Thread.Sleep(2000);
            NotifyListeners(years);
        }
    }
}