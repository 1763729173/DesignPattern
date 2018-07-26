using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsibilityTest
{
    public class ConcreteLeaderB : Leader
    {
        public override void Handle(LeaveRequest request)
        {
            Console.WriteLine("B 审核了请求！");
        }
    }
}
