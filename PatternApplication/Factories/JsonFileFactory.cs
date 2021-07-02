using PatternApplication.FactoryProducts;

namespace PatternApplication.Factories
{
    public class JsonFileFactory: IFileFactory
    {
        public IFile CreateFile(string filePath)
        {
            return new JsonFile(filePath);
        }
    }
}