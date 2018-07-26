using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public abstract class Employee
    {
        public abstract void accept(Department department);
    }
}
