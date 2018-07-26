using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class ConcreteDepartmentB : Department
    {

        public override void visit(GeneralEmployee employee)
        {
            Console.WriteLine("B 访问了 General" + employee.Name);
        }

        public override void visit(ManagerEmployee employee)
        {
            Console.WriteLine("B 访问了 Manager" + employee.Name);
        }
    }
}
