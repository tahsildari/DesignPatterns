using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Decorator
{
    public class EuroPriceDecorator : IPriceService
    {
        private readonly IPriceService priceService;

        public EuroPriceDecorator(IPriceService priceService)
        {
            this.priceService = priceService;
        }

        public string GetPrice() => $"{priceService.GetPrice()} €";
    }
}
