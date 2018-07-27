using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 策略模式
/// </summary>
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Apple apple = new Apple() { weight = 50.0,unitPrice = 50.0 };

            double price = apple.discount();

            Console.WriteLine(price);

            Console.ReadLine();

        }
    }
}
