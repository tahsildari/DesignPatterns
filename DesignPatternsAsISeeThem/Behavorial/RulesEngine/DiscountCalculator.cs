using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules;
using System;
using System.Collections.Specialized;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine
{
    public class DiscountCalculator
    {
        readonly DateOnly TeachersDay = new DateOnly(2000, 10, 5); //Oct 5th

        public DiscountCalculator()
        {
        }
        public DiscountCalculator(DateOnly worldsTeachersDay)
        {
            TeachersDay = worldsTeachersDay;
        }

        // Rules:
        // First purchase has 15% discount for everyone
        // Each year has 1% discount up to a 10% maximum, for teachers 2% more
        // Purchases on birthday have 10% extra discount
        // On teacher's day, teachers get 7% extra discount
        public decimal Calculate(Customer customer)
        {
            var percent = 0m;

            percent = Math.Max(new FirstTimeCustomerRule().Calculate(customer, percent), percent);
            percent = Math.Max(new LoyalCustomerRule().Calculate(customer, percent), percent);
            percent = Math.Max(new TeacherCustomerRule(TeachersDay).Calculate(customer, percent), percent);
            percent = Math.Max(new BirthdayRule().Calculate(customer, percent), percent);

            return percent;
        }
    }
}