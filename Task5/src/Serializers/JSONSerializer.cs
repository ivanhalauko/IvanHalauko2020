using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializers
{
    public class JSONSerializer : ISerialiser
    {
        T ISerialiser.Deserialize<T>(string pathToFile)
        {
            throw new NotImplementedException();
        }

        void ISerialiser.Serialize<T>(T obj, string path)
        {
            throw new NotImplementedException();
        }
    }
}
