using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTest
{
    /// <summary>
    /// 保存者
    /// </summary>
    public class Saver
    {
        private MementoInfo mementoInfo = null;

        public Saver(MementoInfo memento)
        {
            mementoInfo = memento;
        }

        public MementoInfo GetMementoInfo()
        {
            return mementoInfo;
        }

        public void SetMementoInfo(MementoInfo memento)
        {
            mementoInfo = memento;
        }

    }
}
