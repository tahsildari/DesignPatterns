using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules
{
    public class TeacherCustomerRule : IDiscountCalculator
    {
        private readonly DateOnly TeachersDay;

        public TeacherCustomerRule(DateOnly worldsTeachersDay)
        {
            this.TeachersDay = worldsTeachersDay;
        }
        public decimal Calculate(Customer customer, decimal percent)
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
    }
}
