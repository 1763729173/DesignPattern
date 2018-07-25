using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public abstract class abstractModel
    {
        private string Name;
        public abstractModel(string name)
        {
            Name = name;
        }

        public abstract int Answer();

        public void Question()
        {
            Console.WriteLine(Name + ":1+1 = ");
            Console.WriteLine(Answer());
        }

    }
}
