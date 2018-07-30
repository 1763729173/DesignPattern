using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTest
{
    /// <summary>
    /// Cpu类
    /// </summary>
    public class Cpu : Component
    {
        public void Start()
        {
            Console.WriteLine("cpu start.");
        }

        public void Stop()
        {
            Console.WriteLine("cpu stop.");
        }
    }
}
