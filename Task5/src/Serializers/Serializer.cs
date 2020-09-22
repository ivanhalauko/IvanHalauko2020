using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkerISerialize;

namespace Serializers
{
    public class Serializer<T>
    {
        /// <summary>
        /// Property path to file.
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Property object.
        /// </summary>
        public T Obj { get; set; }
        /// <summary>
        /// Property serializer.
        /// </summary>
        public ISerialiser Serialiser { get; set; }

        /// <summary>
        /// Property CheckISerialize.
        /// </summary>
        public bool CheckISerialize { get; set; }

        /// <summary>
        /// Property CheckVersion.
        /// </summary>
        public bool CheckVersion { get; set; }
        /// <summary>
        /// Property version.
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="serialiser">Serialiser parameter.</param>
        public Serializer(ISerialiser serialiser)
        {
            Serialiser = serialiser;
        }

        /// <summary>
        /// Constuctor of serializer's class whith parameters.
        /// </summary>
        /// <param name="serialiser">Serializer parameter.</param>
        /// <param name="obj">Object for serializing.</param>
        /// <param name="path">File's path for saving after serializing.</param>
        public Serializer(ISerialiser serialiser, T obj, string path)
        {
            this.Serialiser = serialiser;
            this.Obj = obj;
            this.Path = path;
        }

        public Serializer(ISerialiser serialiser, bool checkISerialize, bool checkVersion, Version version) : this(serialiser)
        {
            CheckISerialize = checkISerialize;
            CheckVersion = checkVersion;
            Version = version;
        }


        /// <summary>
        /// Serialize method.
        /// </summary>
        public void Serialize(T obj, string path)
        {
            ISerialiser serialiser = (ISerialiser)Serialiser;
            if (CheckISerialize)
            {
                if (obj is MarkerISerialize.ISerialize)
                {
                    serialiser.Serialize(obj, path);
                }
                else
                    throw new System.InvalidCastException();
            }
            else
            {
                serialiser.Serialize(obj, path);
            } 
        }
        /// <summary>
        /// Deserialize method.
        /// </summary>
        public T Deserialize(string path)
        {
            ISerialiser deserialize = (ISerialiser)Serialiser;
            var deserializeObj = deserialize.Deserialize<T>(path);
            if (CheckVersion)
            {
                Version version = (Version)deserializeObj.GetType().GetProperty("Version").GetValue(deserializeObj, null);

                if (!Version.Equals(version))
                {
                    throw new System.ArgumentException("Version do not equal");
                }
                return deserializeObj;
            }
            else
            {
                return deserializeObj;
            }
        }
    }
}
