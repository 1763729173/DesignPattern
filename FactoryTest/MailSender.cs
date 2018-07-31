using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    public class MailSender : Sender
    {
        public void Send()
        {
            Console.WriteLine("创建了MailSender");
        }
    }
}
