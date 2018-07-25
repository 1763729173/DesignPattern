using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    /// <summary>
    /// 具体命令
    /// </summary>

    public class ConcreteCommand:ICommand
    {
        private Receiver receiver;

        public void setReceiver(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void action()
        {
            receiver.run();
        }
    }
}
