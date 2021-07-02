using PatternApplication.FactoryProducts;

namespace PatternApplication.Factories
{
    public class XmlFileFactory: IFileFactory
    {
        public IFile CreateFile(string filePath)
        {
            return new XmlFile(filePath);
        }
    }
}