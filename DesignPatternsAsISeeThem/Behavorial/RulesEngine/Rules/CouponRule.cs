using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules
{
    public class CouponRule : IDiscountCalculator
    {
        Dictionary<string, decimal> coupons = new Dictionary<string, decimal> 
        { 
            { "BLACK-FRIDAY-25", .25m }, 
            { "X-MASS-18", .18m } 
        };

        public decimal Calculate(Customer customer, decimal percent)
        {
            if (customer.Coupon.Length > 0 && coupons.ContainsKey(customer.Coupon))
                percent += coupons[customer.Coupon];
            return percent;
        }
    }
}
