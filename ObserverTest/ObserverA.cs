using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    /// <summary>
    /// 观察者A
    /// </summary>
    class ObserverA : IObserver
    {
        public void action()
        {
            Console.WriteLine("A执行动作!");
        }
    }
}
