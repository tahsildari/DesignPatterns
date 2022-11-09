using System;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Decorator
{
    public class PriceService : IPriceService
    {
        public string GetPrice()
        {
            return "200000"; //200k
        }
    }
}
