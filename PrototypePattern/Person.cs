using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 人
    /// </summary>
    [Serializable]
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
