using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 打折器
    /// </summary>
    public interface Discountor
    {
        double disCountSell(IDiscountable d);
    }
}
