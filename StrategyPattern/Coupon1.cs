using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Coupon1 : Coupon
    {
        public double moneyCodition { get; set; }
        public double monyReturn { get; set; }

        public Coupon1(double MoneyCodition, double MoneyReturn)
        {
            moneyCodition = moneyCodition;
            monyReturn = MoneyReturn;
        }
        public override double finalPay(double money)
        {
            if (money >= moneyCodition)
            {
                return money - monyReturn;
            }
            else
            {
                return money;
            }
        }
    }
}
