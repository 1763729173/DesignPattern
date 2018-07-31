using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    public class SmsSender : Sender
    {
        public void Send()
        {
            Console.WriteLine("创建了SmsSender");
        }
    }
}
