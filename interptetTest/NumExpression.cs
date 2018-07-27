using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interptetTest
{
    public class NumExpression : ArithmeticExpression
    {
        private int num;

        public NumExpression(int num)
        {
            this.num = num;
        }

        public override int interptet()
        {
            return num;
        }
    }
}
