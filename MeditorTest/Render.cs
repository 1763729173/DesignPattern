using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditorTest
{

    /// <summary>
    /// 求租者
    /// </summary>
    public class Render : Person
    {
        public Render(string name) : base(name)
        {
        }

        public override void GetMessage(string message)
        {
            Console.WriteLine("求租者" + GetName() + "，收到中介的消息:" + message);
        }
        public override void SendMessage(string message)
        {
            mediator.Opreator(this,message);
        }
    }
}
