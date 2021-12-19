using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class ColdPizzaBuilder : PizzaRecipe
    {

        public override void AddCheese()
        {
            pizza.cheese = "white cheese";
        }

        public override void AddSauce()
        {
            pizza.sauce = "katchup";
        }

        public override void AddTopings()
        {
            pizza.toppings = "pepperoni+mushroom";
        }

        public override void BakePizza()
        {
            pizza.baked = false;
        }

        public override void BoxPizza()
        {
            pizza.boxed = false;
        }

        public override void PrepareDough()
        {
            pizza.dough = Dough.StoreBought;
        }
    }
}
