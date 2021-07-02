using System.Xml;

namespace PatternApplication.FactoryProducts
{
    public class XmlFile: IFile
    {
        public string FilePath { get; set; }
        public XmlFile(string filePath)
        {
            FilePath = filePath + ".xml";
        }
        
        public string ReadValueByProperty(string property)
        {
            using (XmlReader reader = XmlReader.Create(FilePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name.ToString() == property)
                        {
                            return reader.ReadString();
                        }
                    }
                }
            }

            return "Element doesn't exist";
        }

        public void WriteValueToProperty(string property, string value)
        {
            XmlTextWriter textWriter = new XmlTextWriter(FilePath, null);
            textWriter.WriteStartDocument();
            textWriter.WriteComment("Here is your element: " + property);
            textWriter.WriteStartElement(property);
            textWriter.WriteValue(value);
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }
    }
}