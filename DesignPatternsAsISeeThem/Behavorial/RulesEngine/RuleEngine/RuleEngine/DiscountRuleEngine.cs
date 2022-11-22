using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;
using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.RuleEngine.RuleEngine
{
    public class DiscountRuleEngine
    {
        List<IDiscountCalculator> rules = new List<IDiscountCalculator>();

        public DiscountRuleEngine(List<IDiscountCalculator> rules)
        {
            this.rules = rules;
        }

        public decimal CaculateDiscountPercentage(Customer customer)
        {
            var percent = 0m;

            rules.ForEach(rule =>
            {
                percent = Math.Max(rule.Calculate(customer, percent), percent);
            });

            return percent;
        }
    }
}
