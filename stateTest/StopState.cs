using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateTest
{
    /// <summary>
    /// 关闭状态
    /// </summary>
    public class StopState : IState
    {
        private Machine machine;

        public StopState(Machine machine)
        {
            this.machine = machine;
        }

        public void PrintState()
        {
            Console.WriteLine("机器处于停止状态！");
        }

        public void Start()
        {
            machine.SetSate(machine.startSate);
        }

        public void Stop()
        {
            Console.WriteLine("已经处于关闭状态,不能关闭！");
        }
    }
}
