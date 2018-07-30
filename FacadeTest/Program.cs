using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 外观模式
/// </summary>
namespace FacadeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            Memory memory = new Memory();
            Computer computer = new Computer() { cpu = cpu, memory = memory };
            computer.Start();
            computer.Stop();

            Console.ReadLine();
        }
    }
}
