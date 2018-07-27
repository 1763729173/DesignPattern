using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interptetTest
{
    public class Calculator
    {
        protected Stack<ArithmeticExpression> expressions = new Stack<ArithmeticExpression>();

        public Calculator(string expression)
        {
            ArithmeticExpression expression1, expression2;
            string[] elems = expression.Split(' ');
            for(var i = 0; i < elems.Length; i++)
            {
                switch (elems[i][0])
                {
                    case '+':
                        expression1 = expressions.Pop();
                        expression2 = new NumExpression(int.Parse(elems[++i]));
                        expressions.Push(new AdditionExpression(expression1, expression2));
                        break;
                    default:
                        expressions.Push(new NumExpression(int.Parse(elems[i])));
                        break;
                }
            }
        }

        public int Calulate()
        {
            return expressions.Pop().interptet();
        }
    }
}
