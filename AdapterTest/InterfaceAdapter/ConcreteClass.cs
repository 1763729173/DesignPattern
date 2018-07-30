using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTest.InterfaceAdapter
{
    /// <summary>
    /// 具体实现类
    /// </summary>
    public class ConcreteClass:MiddleClass
    {
        public new void method1()
        {
            Console.WriteLine("重写了method1方法");
        }
    }
}
