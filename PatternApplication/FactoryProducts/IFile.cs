namespace PatternApplication.FactoryProducts
{
    public interface IFile
    {
        public string FilePath { get; set; }
        string ReadValueByProperty(string property);
        void WriteValueToProperty(string property, string value);
    }
}