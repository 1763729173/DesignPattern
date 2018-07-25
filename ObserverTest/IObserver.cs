using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    /// <summary>
    /// 观察者
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 行动
        /// </summary>
        void action();
    }
}
