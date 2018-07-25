using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 苹果类
    /// </summary>
    public class Apple:Goods,IDiscountable
    {
        private AppleWeightDiscounter discounter = new AppleWeightDiscounter();

        public double discount()
        {
            return discounter.disCountSell(this);
        }

    }
}
