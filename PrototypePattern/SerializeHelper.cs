using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    /// <summary>
    /// 序列化帮助器
    /// </summary>
    public class SerializeHelper
    {
        public static byte[] Serialize(object obj)
        {
            using(MemoryStream stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }
        public static T Deserialize<T>(byte[] arr)
        {
            using(MemoryStream stream = new MemoryStream(arr))
            {
                var formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
