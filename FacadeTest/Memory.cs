using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTest
{

    /// <summary>
    /// 内存类
    /// </summary>
    public class Memory : Component
    {
        public void Start()
        {
            Console.WriteLine("memory start.");
        }

        public void Stop()
        {
            Console.WriteLine("memory stop.");
        }
    }
}
