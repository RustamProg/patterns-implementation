using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace PatternApplication.FactoryProducts
{
    public class JsonFile: IFile
    {
        public string FilePath { get; set; }

        public JsonFile(string filePath)
        {
            FilePath = filePath + ".json";
        }
        
        public string ReadValueByProperty(string property)
        {
            var dict = new Dictionary<string, string>();
            var jsonSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                dict = jsonSerializer.ReadObject(fs) as Dictionary<string, string>;
            }

            return dict[property];
        }

        public void WriteValueToProperty(string property, string value)
        {
            var dict = new Dictionary<string, string>() {{property, value}};
            var jsonSerializer =
                new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            using (FileStream fs = new FileStream(FilePath, FileMode.CreateNew))
            {
                jsonSerializer.WriteObject(fs, dict);
            }
        }
    }
}