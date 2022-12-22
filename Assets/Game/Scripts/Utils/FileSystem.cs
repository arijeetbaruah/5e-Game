using Sirenix.Serialization;
using System.IO;

namespace Game.Utils
{
    /// <summary>
    /// Handles File IO functions
    /// </summary>
    public static class FileSystem
    {
        /// <summary>
        /// Write data into a file
        /// </summary>
        /// <typeparam name="T">Data Type of the Data</typeparam>
        /// <param name="data">the data to be stored</param>
        /// <param name="filePath">file save location</param>
        public static void Write<T>(T data, string filePath)
        {
            byte[] jsonContent = SerializationUtility.SerializeValue<T>(data, DataFormat.JSON);
            File.WriteAllBytes(filePath, jsonContent);
        }

        /// <summary>
        /// Read data from the file
        /// </summary>
        /// <typeparam name="T">Data Type of the Data</typeparam>
        /// <param name="filePath">file save location</param>
        /// <returns>The Data stored in file</returns>
        public static T Read<T>(string filePath)
        {
            byte[] jsonContent = File.ReadAllBytes(filePath);
            return SerializationUtility.DeserializeValue<T>(jsonContent, DataFormat.JSON);
        }
    }
}
