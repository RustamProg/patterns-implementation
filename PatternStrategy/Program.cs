using System;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterStrategy printer = new ColumnPrinter();
            PrinterContext context = new PrinterContext(printer);
            context.Print("Everything will be ok!");
        }
    }
}