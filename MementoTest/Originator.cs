using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTest
{
    /// <summary>
    /// 发起者
    /// </summary>
    public class Originator
    {
        private string state;
        public MementoInfo CreateMementoInfo()
        {
            return new MementoInfo(state);
        }

        public void RestoreMementoInfo(MementoInfo memento)
        {
            this.state =  memento.GetState();
        }
        public string GetState()
        {
            return state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
    }
}
