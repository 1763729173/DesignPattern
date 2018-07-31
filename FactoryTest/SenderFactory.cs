using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    public class SenderFactory
    {
        public Sender GetSender(string senderName)
        {
            try
            {
                var type = GetType();
                var nameSpace = type.Namespace;
                object obj = type.Assembly.CreateInstance(nameSpace + "." + senderName);
                return (Sender)obj;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
