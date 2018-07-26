using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public abstract class Department
    {
        public abstract void visit(GeneralEmployee employee);

        public abstract void visit(ManagerEmployee employee);
    }
}
