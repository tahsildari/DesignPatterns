using DesignPatternsAsISeeThem.Behavorial.RulesEngine;
using DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context;

namespace Tests
{
    public class DiscountCalculatorRulesEngineTests
    {
        [Fact]
        public void Return15PercentForFirstBuyEver()
        {
            Customer customer = new Customer
            {
                Birthdate = new DateTime(1989, 7, 16),
                DateOfFirstPurchase = default(DateTime?)
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(.15m);
        }
    }
}