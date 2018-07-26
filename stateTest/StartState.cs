using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateTest
{

    /// <summary>
    /// 开启状态
    /// </summary>
    public class StartState : IState
    {
        private Machine machine;

        public StartState(Machine machine)
        {
            this.machine = machine;
        }

        public void PrintState()
        {
            Console.WriteLine("机器处于开启状态！");
        }

        public void Start()
        {
            Console.WriteLine("已经处于开启状态,不能开启!");
        }

        public void Stop()
        {
            machine.SetSate(machine.stopState);
        }
    }
}
