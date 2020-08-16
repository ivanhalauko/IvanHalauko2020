using System.IO;
using System.Xml.Serialization;

namespace Serializers
{
    public class XMLSerializer
    {
        public void Serialize<T>(T obj)
        {
            var nameOfObjectType = obj.GetType().Name;
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(nameOfObjectType+".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }

        }
    }
}
