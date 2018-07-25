using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTest
{
    /// <summary>
    /// 迭代器接口
    /// </summary>
    public interface IIterator
    {
        void MoveNext();

        bool IsDone();

        object GetElement();

        void First();

    }
}
