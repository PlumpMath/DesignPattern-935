using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NoCoupon : Coupon
    {
        public override double finalPay(double money)
        {
            return money;
        }
    }
}
