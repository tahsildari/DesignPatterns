using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using DesignPatternsAsISeeThem.Behavorial.RulesEngine.RuleEngine.RuleEngine;
using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules;
using System;
using System.Collections.Generic;
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
        // New rule:
        // !!! For customers who have a Coupon the only additional discount allowed is birthday
        public decimal Calculate(Customer customer)
        {
            var rules =
                string.IsNullOrEmpty(customer.Coupon)
                ? GetNormalDiscountCalculators()
                : GetCouponDiscountCalculators();

            return new DiscountRuleEngine(rules).CaculateDiscountPercentage(customer);
        }

        private List<IDiscountCalculator> GetCouponDiscountCalculators()
        {
            var rules = new List<IDiscountCalculator>();

            rules.Add(new CouponRule());
            rules.Add(new BirthdayRule());

            return rules;
        }

        private List<IDiscountCalculator> GetNormalDiscountCalculators()
        {
            var rules = new List<IDiscountCalculator>();

            rules.Add(new FirstTimeCustomerRule());
            rules.Add(new LoyalCustomerRule());
            rules.Add(new TeacherCustomerRule(TeachersDay));
            rules.Add(new BirthdayRule());

            return rules;
        }

    }
}