using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializers
{
    public class Serializer<T>
    {
        public string Path { get; set; }
        public T Obj { get; set; }
        public ISerialiser Serialiser { get; set; }

        public Serializer(ISerialiser serialiser, T obj, string path)
        {
            this.Serialiser = serialiser;
            this.Obj = obj;
            this.Path = path;

        }

        public void Serialize()
        {
            Serialiser.Serialize<T>(Obj,Path);
        }

        public void Deserialize()
        {
            Serialiser.Deserialize<T>(Path);
        }

    }
}
