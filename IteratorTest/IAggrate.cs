using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTest
{
    /// <summary>
    /// 聚集接口
    /// </summary>
    public interface IAggrate
    {
        IIterator GetIterator();
    }
}
