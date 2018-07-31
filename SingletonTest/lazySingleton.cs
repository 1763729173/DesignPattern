using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonTest
{

    /// <summary>
    /// 懒汉加载
    /// </summary>
    public class lazySingleton
    {
        //私有对象
        private static lazySingleton singleton = null;

        private static readonly object syncRoot = new object();
        //私有构造函数
        private lazySingleton() { }

        /// <summary>
        /// 得到该类的单例对象(双重锁判断)
        /// </summary>
        /// <returns></returns>
        public static lazySingleton GetInstance()
        {
            if(singleton == null)
            {
                //lock不能锁值类型和null对象
                lock (syncRoot)
                {
                    if (singleton == null)
                    {
                        singleton = new lazySingleton();
                        Console.WriteLine("创建对象");
                    }
                } 
            }
            return singleton;
        }
    }
}
