using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules
{
    public class BirthdayRule : IDiscountCalculator
    {
        public decimal Calculate(Customer customer, decimal percent)
        {
            if (customer.Birthdate.Month == DateTime.Now.Month
                && customer.Birthdate.Day == DateTime.Now.Day)
                percent += .10m;
            return percent;
        }
    }
}
