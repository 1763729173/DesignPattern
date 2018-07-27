using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 解释器模式
/// </summary>
namespace interptetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "123 + 123 + 123";
            Calculator calculator = new Calculator(expression);
            Console.WriteLine(calculator.Calulate());

            Console.ReadLine();
        }
    }
}
