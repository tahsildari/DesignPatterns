using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Decorator
{
    public class PriceSeparatorDecorator : IPriceService
    {
        IPriceService _priceService { get; }

        public PriceSeparatorDecorator(IPriceService priceService)
        {
            _priceService = priceService;
        }


        public string GetPrice()
        {
            var price = _priceService.GetPrice();
            var priceAsNumber = int.Parse(price);
            return string.Format("{0:N0}", priceAsNumber);

        }
    }
}
