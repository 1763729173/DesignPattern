using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class StudentAModel : abstractModel
    {
        public StudentAModel(string name) : base(name)
        {
        }

        public override int Answer()
        {
            return 2;
        }
    }
}
