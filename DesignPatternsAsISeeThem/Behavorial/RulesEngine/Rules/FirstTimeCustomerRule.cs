using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules
{
    public class FirstTimeCustomerRule : IDiscountCalculator
    {
        public decimal Calculate(Customer customer, decimal percent)
        {
            if (customer.DateOfFirstPurchase == null)
                return .15m;
            return 0m;
        }
    }
}
