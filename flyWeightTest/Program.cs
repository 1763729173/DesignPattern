using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace flyWeightTest
{


    class Program
    {
        public static int fun()
        {
            return 100;
        }
        public static void fun1()
        {
            
        }
        static void Main(string[] args)
        {
            Gymnasium gymnasium = GymnasiumFactory.GetGymnasium("篮球");
            Gymnasium gymnasium1 = GymnasiumFactory.GetGymnasium("篮球");

            //Console.WriteLine(gymnasium.Equals(gymnasium1));
            //Console.WriteLine(gymnasium == gymnasium1);

            var func = new Func<int>(fun);
            int a = 100;
            var result = Task.Run(func).ContinueWith( p => { return p.Result + 1; });

            NameValueCollection collection = new NameValueCollection();
            collection["1"] = "123";
            Console.WriteLine(collection.GetValues("12")?.FirstOrDefault());


            //Console.WriteLine(gymnasium?.Name);
            Console.ReadLine();
        }
    }
}
