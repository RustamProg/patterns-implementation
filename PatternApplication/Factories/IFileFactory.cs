using PatternApplication.FactoryProducts;

namespace PatternApplication.Factories
{
    public interface IFileFactory
    {
        IFile CreateFile(string filePath);
    }
}