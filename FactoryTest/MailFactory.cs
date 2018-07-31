using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    public class MailFactory : Provider
    {
        public Sender Produce()
        {
            return new MailSender();
        }
    }
}
