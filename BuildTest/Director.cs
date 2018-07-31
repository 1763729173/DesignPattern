using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTest
{

    /// <summary>
    /// 建造者
    /// </summary>
    public class Director
    {
        public static Product GetProduct(IBuilder builder)
        {
            builder.buildBasic();
            builder.buildWall();
            builder.buildRoofed();
            return builder.GetProduct();
        }
    }
}
