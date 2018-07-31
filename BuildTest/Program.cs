using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 建造者模式
/// </summary>
namespace BuildTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new ConcreteBuilder();
            var product = Director.GetProduct(builder);
            Console.WriteLine(product.basic);
            Console.WriteLine(product.wall);
            Console.WriteLine(product.roofed);
            Console.ReadLine();
        }
    }
}
