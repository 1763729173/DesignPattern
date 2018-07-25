using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand();
            command.setReceiver(receiver);
            Invoker invoker = new Invoker();
            invoker.setCommand(command);
            invoker.action();

            Console.ReadLine();

        }
    }
}
