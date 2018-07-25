using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorateTest
{
    public class CarRadar:CarTrim
    {
        public CarRadar(IDecorate myCar):base(myCar)
        {

        }
        public override void Show()
        {
            Console.WriteLine("具有倒车雷达的功能");
            base.Show();
        }
    }
}
