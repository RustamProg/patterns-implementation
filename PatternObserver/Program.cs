using System;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var changer = new AgeChanger();
            var rustam = new RustamListener();
            var ivan = new IvanListener();
            changer.AddListener(rustam);
            changer.AddListener(ivan);
            changer.NotifyListeners(0);
            changer.SkipYears(12);
        }
    }
}