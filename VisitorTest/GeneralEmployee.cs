using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class GeneralEmployee : Employee
    {
        public string Name { get; set; }
        public override void accept(Department department)
        {
            department.visit(this);
        }
    }
}
