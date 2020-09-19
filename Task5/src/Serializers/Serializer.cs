using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializers
{
    public class Serializer
    {

        public ISerialiser Serialiser { get; set; }

        public Serializer(ISerialiser serialiser)
        {
            this.Serialiser = serialiser;
        }

    }
}
