using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interptetTest
{
    public abstract class OperatorExpression : ArithmeticExpression
    {
        protected ArithmeticExpression expression, expression1;
        public OperatorExpression(ArithmeticExpression expression,ArithmeticExpression expression1)
        {
            this.expression = expression;
            this.expression1 = expression1;
        }

    }
}
