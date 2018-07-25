using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorateTest
{
    public class Car:IDecorate
    {
        private string _name;
        public Car(string name)
        {
            this._name = name;
        }
        public void Show()
        {
            Console.WriteLine("this is my car {0}.", _name);
        }
    }
}
