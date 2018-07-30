using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTest.ClassAdapter
{
    public class MyAdapter : Usber, Ps2
    {
        public void isPs2()
        {
            isUsb();
        }
    }
}
