using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 装饰者模式
/// </summary>
namespace decorateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("宝马");
            CarRadar carRadar = new CarRadar(car);
            carRadar.Show();
            Console.ReadLine();
        }
    }
}
