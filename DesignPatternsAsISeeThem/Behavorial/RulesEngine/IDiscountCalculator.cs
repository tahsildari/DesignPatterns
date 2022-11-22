using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine
{
    public interface IDiscountCalculator
    {
        decimal Calculate(Customer customer);
    }
}