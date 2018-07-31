using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    /// <summary>
    /// 饿汉加载
    /// </summary>
    public class hungrySingleTon
    {
        private static hungrySingleTon singleTon = new hungrySingleTon();
        private hungrySingleTon() { }

        public static hungrySingleTon getInstance()
        {
            return singleTon;
        }
    }
}
