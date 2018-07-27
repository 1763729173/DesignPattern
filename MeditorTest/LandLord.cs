using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditorTest
{
    /// <summary>
    /// 房屋出租者
    /// </summary>
    public class LandLord : Person
    {
        public LandLord(string name) : base(name)
        {
        }

        public override void GetMessage(string message)
        {
            Console.WriteLine("房屋出租者"+ GetName() + "，收到中介的消息:" + message);
        }

        public override void SendMessage(string message)
        {
            mediator.Opreator(this,message);
        }
    }
}
