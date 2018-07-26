using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new Machine();
            machine.PrintState();
            machine.Stop();
            machine.PrintState();
            machine.Start();
            machine.PrintState();
            machine.Start();

            Console.ReadLine();
        }
    }
}
