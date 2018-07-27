using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 迭代子模式
/// </summary>
namespace IteratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = { "1", "2", "3", "4", "5", "6" };

            var aggrate = new ConcreteAggrate(arr);

            Console.WriteLine("this is for loop!");

            for (var i = 0; i < aggrate.GetSize(); i++)
            {
                Console.WriteLine(aggrate.GetElement(i));
            }
            Console.WriteLine("this is iterator loop!");

            IIterator iterator = aggrate.GetIterator();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.GetElement());
                iterator.MoveNext()
                    ;
            }
            Console.ReadLine();
        }
    }
}
