using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new RealSubject();
            ProxySubject proxySubject = new ProxySubject();
            proxySubject.subject = subject;
            proxySubject.visit();

            Console.ReadLine();
        }
    }
}
