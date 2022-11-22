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

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,3)]
        [InlineData(4,4)]
        [InlineData(5,5)]
        [InlineData(6,6)]
        [InlineData(7,7)]
        [InlineData(8,8)]
        [InlineData(9,9)]
        [InlineData(10,10)]
        [InlineData(15,10)]
        public void ReturnPercentEqualToYearsOfMembershipForNonTeachersForForMaxOf10(int year, decimal expectedPercent)
        {
            Customer customer = new Customer
            {
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = false
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent / 100);
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 4)]
        [InlineData(3, 5)]
        [InlineData(4, 6)]
        [InlineData(5, 7)]
        [InlineData(6, 8)]
        [InlineData(7, 9)]
        [InlineData(8, 10)]
        [InlineData(9, 11)]
        [InlineData(10, 12)]
        [InlineData(15, 12)]
        public void ReturnPercentEqualToYearsOfMembershipPlusTwoForTeachersForMaxOf12(int year, decimal expectedPercent)
        {
            Customer customer = new Customer
            {
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = true
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent / 100);
        }
    }
}