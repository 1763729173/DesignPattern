using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 代理模式
/// </summary>
namespace ProxyTest
{
    public class ProxySubject:Subject
    {
        public Subject subject { get; set; }

        public void visit()
        {
            subject.visit();
        }
    }
}
