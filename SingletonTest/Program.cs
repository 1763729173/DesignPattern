using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonTest
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 5, i =>
              {
                  lazySingleton.GetInstance();
                  Console.WriteLine("迭代次数：{0},任务ID:{1},线程ID:{2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
              });
            Console.ReadLine();
        }
    }
}
