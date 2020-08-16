using System.IO;
using System.Xml.Serialization;

namespace Serializers
{
    public class XMLDeserializer
    {
        public T Deserialize<T>(string pathToFile)
        {
            if (!new FileInfo(pathToFile).Exists)
                throw new FileNotFoundException("Path to file is not correct.");

            XmlSerializer formatter = new XmlSerializer(typeof(T));
            T newDeserialaize;

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                newDeserialaize = (T)formatter.Deserialize(fs);
            }
            return newDeserialaize;
        }
    }
}
