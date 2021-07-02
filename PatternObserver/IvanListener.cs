using System;

namespace PatternObserver
{
    public class IvanListener: IEventListener
    {
        public int Age { get; set; } = 40;
        public void Update(int age)
        {
            Age += age;
            Console.WriteLine("Ivan: I'm old! I'm " + Age);
        }
    }
}