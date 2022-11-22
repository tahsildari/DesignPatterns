using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Specialized;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine
{
    public class DiscountCalculator
    {
        public DiscountCalculator()
        {
        }

        // Rules:
        // First purchase has 15% discount for everyone
        // Each year has 1% discount up to a 10% maximum, for teachers 2-12%
        // Purchases on birthday have 10% extra discount
        // On teacher's day, teachers get 7% extra discount
        public decimal Calculate(Customer customer)
        {
            var percent = 0m;
            if (customer.DateOfFirstPurchase == null)
                percent = .15m;
            else
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                    percent = .10m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-9))
                    percent = .09m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-8))
                    percent = .08m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-7))
                    percent = .07m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-6))
                    percent = .06m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                    percent = .05m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-4))
                    percent = .04m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-3))
                    percent = .03m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2))
                    percent = .02m;
                else if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
                    percent = .01m;

                if (customer.IsTeacher)
                    percent += .02m;
            }
            return percent;
        }
    }
}