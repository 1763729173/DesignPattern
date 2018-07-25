using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTest
{
    /// <summary>
    /// 具体的迭代器
    /// </summary>
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggrate aggrate = null;

        private int Index = 0;

        public ConcreteIterator(ConcreteAggrate aggrate)
        {
            this.aggrate = aggrate;
            Index = 0;
        }

        public void First()
        {
            Index = 0;
        }

        public object GetElement()
        {
            return aggrate.GetElement(Index);
        }

        public bool IsDone()
        {
            return (Index >= aggrate.GetSize());
        }

        public void MoveNext()
        {
            if (Index <= aggrate.GetSize())
                Index++;
        }
    }
}
