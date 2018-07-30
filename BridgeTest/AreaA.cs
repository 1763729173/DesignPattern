using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    /// <summary>
    /// 桥的A端口
    /// </summary>
    public abstract class AreaA
    {
        public Qiao qiao { get; set; }
        public abstract void FromAreaA();
    }
}
