using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class ConcreteDepartmentA : Department
    {
        public override void visit(GeneralEmployee employee)
        {
            Console.WriteLine("A 访问了 General" + employee.Name);
        }

        public override void visit(ManagerEmployee employee)
        {
            Console.WriteLine("A 访问了 Manager " + employee.Name);
        }
    }
}
