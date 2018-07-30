using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTest
{

    /// <summary>
    /// 计算机类
    /// </summary>
    public class Computer:Component
    {
        public Cpu cpu { get; set; }
        public Memory memory { get; set; }
        public void Start()
        {
            cpu.Start();
            memory.Stop();
        }
        public void Stop()
        {
            cpu.Stop();
            memory.Stop();
        }
    }
}
