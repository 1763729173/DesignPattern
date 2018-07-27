using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 备忘录模式
/// </summary>
namespace MementoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            originator.SetState("off");
            var saver = new Saver(originator.CreateMementoInfo());
            originator.SetState("on");
            Console.WriteLine(originator.GetState());
            originator.RestoreMementoInfo(saver.GetMementoInfo());
            Console.WriteLine(originator.GetState());

            Console.ReadLine();
        }
    }
}
