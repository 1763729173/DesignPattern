using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    /// <summary>
    /// 通知者
    /// </summary>
    public interface INoticer
    {
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        void addObserver(IObserver observer);
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        void removerObserver(IObserver observer);
        /// <summary>
        /// 通知观察者
        /// </summary>
        void notice();
    }
}
