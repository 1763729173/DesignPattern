using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTest
{
    /// <summary>
    /// 备忘本
    /// </summary>
    public class MementoInfo
    {
        private string State;

        public MementoInfo(string state)
        {
            this.State = state;
        }

        public string GetState()
        {
            return State;
        }

        public void SetState(string state)
        {
            State = state;
        }
    }
}
