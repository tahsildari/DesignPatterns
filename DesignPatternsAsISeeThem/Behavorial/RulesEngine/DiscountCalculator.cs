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
            if (customer.DateOfFirstPurchase == null)
                return .15m;
            else
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                    return 10;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-9))
                    return 9;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-8))
                    return 8;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-7))
                    return 7;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-6))
                    return 6;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                    return 5;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-4))
                    return 4;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-3))
                    return 3;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2))
                    return 2;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
                    return 1;
                return 0m;
            }
        }
    }
}