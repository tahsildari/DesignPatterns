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
        [InlineData(false)]
        [InlineData(true)]
        public void Return25PercentForFirstBuyOnBirthdayRegardlessOfJob(bool isTeacher)
        {
            var today = DateTime.Today;
            Customer customer = new Customer
            {
                Birthdate = new DateTime(2000, today.Month, today.Day),
                DateOfFirstPurchase = default(DateTime?),
                IsTeacher = isTeacher
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(.25m);
        }

        [Theory]
        [InlineData(1, .01)]
        [InlineData(2, .02)]
        [InlineData(3, .03)]
        [InlineData(4, .04)]
        [InlineData(5, .05)]
        [InlineData(6, .06)]
        [InlineData(7, .07)]
        [InlineData(8, .08)]
        [InlineData(9, .09)]
        [InlineData(10, .10)]
        [InlineData(15, .10)]
        public void ReturnPercentEqualToYearsOfMembershipForNonTeachersForForMaxOf10(int year, decimal expectedPercent)
        {
            Customer customer = new Customer
            {
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = false
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent);
        }

        [Theory]
        [InlineData(1, .03)]
        [InlineData(2, .04)]
        [InlineData(3, .05)]
        [InlineData(4, .06)]
        [InlineData(5, .07)]
        [InlineData(6, .08)]
        [InlineData(7, .09)]
        [InlineData(8, .10)]
        [InlineData(9, .11)]
        [InlineData(10, .12)]
        [InlineData(15, .12)]
        public void ReturnPercentEqualToYearsOfMembershipPlusTwoForTeachersForMaxOf12(int year, decimal expectedPercent)
        {
            Customer customer = new Customer
            {
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = true
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent);
        }

        [Theory]
        [InlineData(1, .11)]
        [InlineData(5, .15)]
        [InlineData(10, .20)]
        [InlineData(15, .20)]
        public void ReturnMembershipYearsPlusTenPercentForNonTeacherOnBirthday(int year, decimal expectedPercent)
        {
            var today = DateTime.Today;
            Customer customer = new Customer
            {
                Birthdate = new DateTime(2000, today.Month, today.Day),
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = false
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent);
        }

        [Theory]
        [InlineData(1, .13)]
        [InlineData(5, .17)]
        [InlineData(10, .22)]
        [InlineData(15, .22)]
        public void ReturnMembershipYearsPlusTwoPlusTenPercentForTeacherOnBirthday(int year, decimal expectedPercent)
        {
            var today = DateTime.Today;
            Customer customer = new Customer
            {
                Birthdate = new DateTime(2000, today.Month, today.Day),
                DateOfFirstPurchase = DateTime.Now.AddYears(-1 * year),
                IsTeacher = true
            };

            var sut = new DiscountCalculator();
            var percent = sut.Calculate(customer);

            percent.Should().Be(expectedPercent);
        }

        [Fact]
        public void ReturnMembershipYearsPlusSevenOnTeachersDay()
        {
            Customer customer = new Customer
            {
                DateOfFirstPurchase = DateTime.Today.AddYears(-4),
                IsTeacher = true
            };

            var fictionalTeachersDay = DateOnly.FromDateTime(DateTime.Today);
            var sut = new DiscountCalculator(fictionalTeachersDay);
            var percent = sut.Calculate(customer);

            percent.Should().Be(.11m);
        }

        [Fact]
        public void ReturnMembershipYearsPlusSeventeenOnTeachersDayAndBirthday()
        {
            Customer customer = new Customer
            {
                Birthdate = DateTime.Today.AddYears(-40),
                DateOfFirstPurchase = DateTime.Today.AddYears(-4),
                IsTeacher = true
            };

            var fictionalTeachersDay = DateOnly.FromDateTime(DateTime.Today);
            var sut = new DiscountCalculator(fictionalTeachersDay);
            var percent = sut.Calculate(customer);

            percent.Should().Be(.21m);
        }
    }
}