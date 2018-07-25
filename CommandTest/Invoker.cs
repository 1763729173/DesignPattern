using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    /// <summary>
    /// 命令发出者
    /// </summary>
    public class Invoker
    {
        private ICommand command;

        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        public void action()
        {
            command.action();
        }

    }
}
