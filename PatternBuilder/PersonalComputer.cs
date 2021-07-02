using System;

namespace PatternBuilder
{
    public class PersonalComputer
    {
        public string CpuName { private get; set; } = "None";
        public string GpuName { private get; set; } = "None";
        public int RamValueGBytes { private get; set; } = 0;
        public string PcUser { private get; set; } = "None";

        public void PrintConfiguration()
        {
            Console.WriteLine($"{PcUser} owns PC of next configuration: ");
            Console.WriteLine("CPU: " + CpuName);
            Console.WriteLine("GPU: " + GpuName);
            Console.WriteLine("RAM (GB): " + RamValueGBytes);
        }
    }
}