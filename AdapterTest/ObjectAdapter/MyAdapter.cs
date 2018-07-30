using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTest.ObjectAdapter
{
    public class MyAdapter:Ps2
    {
        private Usb usb;
        public  MyAdapter(Usb usb)
        {
            this.usb = usb;
        }

        public void isPs2()
        {
            usb.isUsb();
        }
    }
}
