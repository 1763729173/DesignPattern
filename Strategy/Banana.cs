using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 香蕉类
    /// </summary>
    public class Banana:Goods,IDiscountable
    {
        
        public double discount()
        {
            return 0.0;
        }
    }
}
