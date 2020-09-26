using System.IO;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;
//using System.Text.Json;


namespace Serializers
{
    /// <summary>
    /// Serialise class.
    /// </summary>
    public class JsonSerializer : ISerialiser
    {
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="obj">Object.</param>
        /// <param name="path">File's path.</param>
        public void Serialize<T>(T obj, string path)
        {
            var nameOfObj = obj.GetType().Name;
            
            using (FileStream fs = new FileStream(path + "/" + nameOfObj + ".json", FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(JsonConvert.SerializeObject(obj));
                fs.Write(array, 0, array.Length);
            }
        }
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="pathToFile">File's path.</param>
        /// <returns></returns>
        public T Deserialize<T>(string pathToFile)
        {
            if (!new FileInfo(pathToFile).Exists)
            {
                throw new FileNotFoundException("Path to file is not correct.");
            }  
            T newDeserialaize;

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                                              
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                string str = Encoding.Default.GetString(array);
                newDeserialaize = JsonConvert.DeserializeObject<T>(str);

            }
            return newDeserialaize;
        }
    }
}
