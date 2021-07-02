using System;

namespace PatternStrategy
{
    public class StairsPrinter: IPrinterStrategy
    {
        public void PrintString(string sentence)
        {
            var words = sentence.Split(' ');
            var space = "";
            foreach (var word in words)
            {
                Console.WriteLine(space + word);
                space += "    ";
            }
        }
    }
}