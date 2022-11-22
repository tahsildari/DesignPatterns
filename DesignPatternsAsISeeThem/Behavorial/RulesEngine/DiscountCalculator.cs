using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Specialized;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine
{
    public class DiscountCalculator : IDiscountCalculator
    {
        readonly DateOnly TeachersDay = new DateOnly(2000, 10, 5); //Oct 5th

        public DiscountCalculator()
        {
        }
        public DiscountCalculator(DateOnly worldsTeachersDay)
        {
            TeachersDay = worldsTeachersDay;
        }

        public decimal CalculateDiscountForFirstTimeCustomer(Customer customer)
        {
            if (customer.DateOfFirstPurchase == null)
                return .15m;
            return 0m;
        }

        public decimal CalculateDiscountForLoyalCustomers(Customer customer)
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

        public decimal CalculateDiscountForTeacherCustomers(Customer customer, decimal percent)
        {
            if (customer.DateOfFirstPurchase.HasValue)
            {
                bool isItTeachersDay =
                    TeachersDay.Day == DateTime.Today.Day &&
                    TeachersDay.Month == DateTime.Today.Month;

                if (customer.IsTeacher)
                    percent += (isItTeachersDay ? .07m : .02m);
            }
            return percent;
        }

        public decimal CalculateDiscountForCustomersBirthday(Customer customer, decimal percent)
        {
            if (customer.Birthdate.Month == DateTime.Now.Month
                && customer.Birthdate.Day == DateTime.Now.Day)
                percent += .10m;
            return percent;
        }

        // Rules:
        // First purchase has 15% discount for everyone
        // Each year has 1% discount up to a 10% maximum, for teachers 2% more
        // Purchases on birthday have 10% extra discount
        // On teacher's day, teachers get 7% extra discount
        public decimal Calculate(Customer customer)
        {
            var percent = 0m;

            percent = Math.Max(CalculateDiscountForFirstTimeCustomer(customer), percent);
            percent = Math.Max(CalculateDiscountForLoyalCustomers(customer), percent);
            percent = Math.Max(CalculateDiscountForTeacherCustomers(customer, percent), percent);
            percent = Math.Max(CalculateDiscountForCustomersBirthday(customer, percent), percent);

            return percent;
        }
    }
}