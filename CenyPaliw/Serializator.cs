using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CenyPaliw
{
    class Serializator
    {
        public static List<T> Deserialize<T>(string a_fileName)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));

            TextReader reader = new StreamReader(a_fileName);

            object obj = deserializer.Deserialize(reader);

            reader.Close();

            return (List<T>)obj;
        }


        public static void Serialize<T>(List<T> a_stations, string a_fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            if (File.Exists(a_fileName))
            {
                File.Delete(a_fileName);
            }

            using (var stream = File.OpenWrite(a_fileName))
            {
                serializer.Serialize(stream, a_stations);
            }
        }
    }
}
