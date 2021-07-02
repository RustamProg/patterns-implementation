namespace PatternStrategy
{
    public class PrinterContext
    {
        private readonly IPrinterStrategy _printerStrategy;

        public PrinterContext(IPrinterStrategy printerStrategy)
        {
            _printerStrategy = printerStrategy;
        }

        public void Print(string str)
        {
            _printerStrategy.PrintString(str);
        }
    }
}