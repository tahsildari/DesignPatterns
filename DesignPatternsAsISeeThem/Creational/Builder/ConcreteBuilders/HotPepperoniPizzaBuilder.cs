using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class HotPepperoniPizzaBuilder : PepperoniPizzaBuilder
    {
        public override void AddSauce()
        {
            pizza.sauce = "hot";
        }
    }
}
