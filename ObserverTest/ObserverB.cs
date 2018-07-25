using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    /// <summary>
    /// 观察者B
    /// </summary>
    public class ObserverB : IObserver
    {
        public void action()
        {
            Console.WriteLine("B执行动作!");
        }
    }
}
