using System;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PcBuilder();
            var director = new Director(builder);
            
            Console.WriteLine("Weak PC: ");
            director.SetWeakConfiguration();
            builder.GetPersonalComputer().PrintConfiguration();

            Console.WriteLine("\nStrong PC: ");
            director.SetStrongConfiguration();
            builder.GetPersonalComputer().PrintConfiguration();

            Console.WriteLine("\nSwitching to the red side");
            builder.SetCpu("AMD Ryzen 5900X");
            builder.SetGpu("AMD Radeon 6900XT");
            builder.GetPersonalComputer().PrintConfiguration();
        }
    }
}