using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializers
{
    public interface ISerialiser
    {
        void Serialize<T>(T obj, string path);

        T Deserialize<T>(string pathToFile);

    }
}
