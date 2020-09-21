using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serializers
{
    /// <summary>
    /// Binary serialize class.
    /// </summary>
    public class BinarySerializer : ISerialiser
    {
        /// <summary>
        /// Serialize object.
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="obj">Object.</param>
        /// <param name="path">File's path.</param>
        public void Serialize<T>(T obj, string path)
        {  
            var nameOfObj = obj.GetType().Name;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path+ "/"+nameOfObj +".dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }

        }
        /// <summary>
        /// Deserialize object.
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="pathToFile">File's path.</param>
        /// <returns></returns>
        public T Deserialize<T>(string pathToFile)
        {
            if (!new FileInfo(pathToFile).Exists)
            {
                throw new FileNotFoundException("Path to file is not correct.");
            }
            BinaryFormatter formatter = new BinaryFormatter();
           
            T newDeserialaize;
          
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                newDeserialaize =(T)formatter.Deserialize(fs); 
            }
            return newDeserialaize;
        }  
    }
}
