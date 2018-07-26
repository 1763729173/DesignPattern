using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsibilityTest
{
    public class ConcreteLeaderA : Leader
    {
        public override void Handle(LeaveRequest request)
        {
            if(request.LeaveDays < 3)
            {
                Console.WriteLine("A 审核了请求！");
            }
            else
            {
                if(leader != null)
                {
                    leader.Handle(request);
                }
            }
        }
    }
}
