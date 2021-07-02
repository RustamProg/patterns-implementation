using System;
using PatternApplication.Factories;
using PatternApplication.FactoryProducts;

namespace PatternApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter factory name: (xml/json)");
            string factoryType = Console.ReadLine();
            IFileFactory factory = new JsonFileFactory();
            switch (factoryType)
            {
                case "xml":
                    factory = new XmlFileFactory();
                    break;
                case "json":
                    factory = new JsonFileFactory();
                    break;
                default:
                    Console.WriteLine("Invalid factory name");
                    break;
            }

            Console.WriteLine("Enter property then value: ");
            var prop = Console.ReadLine();
            var value = Console.ReadLine();

            IFile file = factory.CreateFile("C:/newfile");
            file.WriteValueToProperty(prop, value);
            Console.WriteLine(file.ReadValueByProperty(prop));
        }
    }
}