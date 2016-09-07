using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Coupon2 : Coupon
    {
        private double moneyRebate;

        public Coupon2(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }
        public override double finalPay(double money)
        {
            return money * moneyRebate;
        }
    }
}
