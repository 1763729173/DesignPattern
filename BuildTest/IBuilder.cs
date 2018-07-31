using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTest
{

    /// <summary>
    /// 构造接口
    /// </summary>
    public interface IBuilder
    {
        void buildBasic();
        void buildWall();
        void buildRoofed();
        Product GetProduct();
    }
}
