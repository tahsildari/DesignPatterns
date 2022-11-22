using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules
{
    public class LoyalCustomerRule : IDiscountCalculator
    {
        public decimal Calculate(Customer customer, decimal percent)
        {
            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                    return .10m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-9))
                    return .09m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-8))
                    return .08m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-7))
                    return .07m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-6))
                    return .06m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                    return .05m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-4))
                    return .04m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-3))
                    return .03m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2))
                    return .02m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
                    return .01m;
            }
            return 0m;
        }
    }
}
