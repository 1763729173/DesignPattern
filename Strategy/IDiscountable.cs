using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 可打折的接口
    /// </summary>
    public interface IDiscountable
    {
        double discount();
    }
}
