using System.Collections.Generic;

namespace PatternObserver
{
    public interface IEventManager
    {
        void AddListener(IEventListener listener);
        void RemoveListener(IEventListener listener);
        void NotifyListeners(int age);
    }
}