using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateTest
{
    public class Machine:IState
    {
        public IState stopState;
        public IState startSate;
        private IState state;
        public Machine()
        {
            stopState = new StopState(this);
            startSate = new StartState(this);
            state = stopState;
        }
        public void SetSate(IState state)
        {
            this.state = state;
        }
        public void PrintState()
        {
            state.PrintState();
        }
        public void Stop()
        {
            state.Stop();
        }

        public void Start()
        {
            state.Start();
        }
    }
}
