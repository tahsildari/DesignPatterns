using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class HomeItalianMargarittaPizzaBuilder : PizzaRecipe
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
            pizza.toppings = "tomato+mushroom+corn+pepper";
        }

        public override void BakePizza()
        {
            pizza.baked = true;
        }

        public override void BoxPizza()
        {
            pizza.boxed = true;
        }

        public override void PrepareDough()
        {
            pizza.dough = Dough.HomeMade;
        }
    }
}
