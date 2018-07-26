using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsibilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestA = new LeaveRequest() { Name = "小明", LeaveDays = 2 };
            var requestB = new LeaveRequest() { Name = "小红", LeaveDays = 3 };

            Leader leaderA = new ConcreteLeaderA() { Name = "主管" };
            Leader leaderB = new ConcreteLeaderB() { Name = "经理" };
            leaderA.leader = leaderB;

            leaderA.Handle(requestA);
            leaderA.Handle(requestB);

            Console.ReadLine();

        }
    }
}
