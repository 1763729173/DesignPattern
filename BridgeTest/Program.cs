using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 桥接模式
/// </summary>
namespace BridgeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaA1 areaA1 = new AreaA1();
            Qiao qiao = new AreaB1();
            areaA1.qiao = qiao;
            areaA1.FromAreaA();
            areaA1.qiao.targetAreaB();

            Console.ReadLine();
        }
    }
}
