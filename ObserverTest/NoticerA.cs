using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    /// <summary>
    /// 提醒者A
    /// </summary>
    public class NoticerA : INoticer
    {
        private List<IObserver> observers = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notice()
        {
            Console.WriteLine("提醒者发出消息");
            foreach(var item in observers)
            {
                item.action();
            }
        }

        public void removerObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
