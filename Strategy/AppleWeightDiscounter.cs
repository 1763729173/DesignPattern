using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AppleWeightDiscounter:Discountor
    {
        public double disCountSell(IDiscountable d)
        {
            Apple apple = d as Apple;
            if (apple.weight < 10) return apple.weight * apple.unitPrice;
            else if (apple.weight >= 10 && apple.weight <= 50) return apple.weight * apple.unitPrice * 0.88;
            else
            {
                return apple.weight * apple.unitPrice * 0.6;
            }
        }
    }
}
