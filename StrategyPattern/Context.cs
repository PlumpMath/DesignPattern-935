using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private Coupon coupon;

        public Context(string type)
        {
            switch (type)
            {
                case "300-299":
                    coupon = new Coupon1(300, 299);
                    break;
                case "0.8":
                    coupon = new Coupon2(0.8);
                    break;
                default:
                    coupon = new NoCoupon();
                    break;
            }
        }

        public double finalPay(double money)
        {
            return coupon.finalPay(money);
        }
    }
}
