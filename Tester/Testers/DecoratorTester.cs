using DesignPatternsAsISeeThem.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    public class DecoratorTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            this.IntroduceTester();

            IPriceService rawPriceService = new PriceService();
            IPriceService formattedPriceService = new PriceSeparatorDecorator(new PriceService());
            IPriceService euroFormattedPriceService = new EuroPriceDecorator(formattedPriceService);
            IPriceService dollarPriceService = new DollarPriceDecorator(rawPriceService);

            Console.WriteLine($"Euro price - (formatted): {euroFormattedPriceService.GetPrice()}");
            Console.WriteLine($"Dollar price - (unformatted): {dollarPriceService.GetPrice()}");
        }
    }
}
