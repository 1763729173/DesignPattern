using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsibilityTest
{
    public abstract class Leader
    {
        public string Name { get; set; }

        public Leader leader { get; set; }

        public abstract void Handle(LeaveRequest request);
    }
}
