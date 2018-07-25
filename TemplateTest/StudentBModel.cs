using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class StudentBModel : abstractModel
    {
        public StudentBModel(string name) : base(name)
        {
        }

        public override int Answer()
        {
            return 3;
        }
    }
}
