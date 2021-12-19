using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class DoubleCheesePepperoniPizzaBuilder : PepperoniPizzaBuilder
    {
        public override void AddCheese()
        {
            base.AddCheese();
            pizza.cheese += "+ yellow cheese";
        }
    }
}
