using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTest
{
    /// <summary>
    /// 具体聚集类
    /// </summary>
    public class ConcreteAggrate : IAggrate
    {
        private object[] objs = null;

        public ConcreteAggrate(object[] objs)
        {
            this.objs = objs;
        }

        public int GetSize()
        {
            return objs.Length;
        }

        public object GetElement(int index)
        {
            if (index >= 0 && index < objs.Length)
                return objs[index];
            else
                return null;
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
