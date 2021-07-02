using System;

namespace PatternObserver
{
    public class RustamListener: IEventListener
    {
        public int Age { get; set; } = 19;
        public void Update(int age)
        {
            Age += age;
            Console.WriteLine("Rustam: Now I am " + Age + "! That's nice!");
        }
    }
}