using System;

namespace PatternStrategy
{
    public class ColumnPrinter: IPrinterStrategy
    {
        public void PrintString(string sentence)
        {
            var words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}