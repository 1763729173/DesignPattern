using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTest
{
    public class RealSubject : Subject
    {
        public void visit()
        {
            Console.WriteLine("调用了RealSubject的Visit方法");
        }
    }
}
