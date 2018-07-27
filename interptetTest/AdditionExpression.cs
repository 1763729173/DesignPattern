using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interptetTest
{
    public class AdditionExpression : OperatorExpression
    {
        public AdditionExpression(ArithmeticExpression expression, ArithmeticExpression expression1) : base(expression, expression1)
        {
        }

        public override int interptet()
        {
            return expression.interptet() + expression1.interptet();
        }
    }
}
