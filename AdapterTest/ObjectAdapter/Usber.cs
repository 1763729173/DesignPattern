using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTest.ObjectAdapter
{
    /// <summary>
    /// usb接口的实现类
    /// </summary>
    public class Usber : Usb
    {
        public void isUsb()
        {
            Console.WriteLine("usb接口");
        }
    }
}
