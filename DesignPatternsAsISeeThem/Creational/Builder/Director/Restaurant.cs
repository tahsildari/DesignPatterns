using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class Restaurant
    {
        private PizzaRecipe recipe;
        
        public void SetBuilder(PizzaRecipe pizzaBuilder) {
            this.recipe = pizzaBuilder;
        }

        public Pizza GetPizza() => recipe.GetPizza();

        public void MakePizza() {
            recipe.Reset();
            recipe.PrepareDough();
            recipe.AddSauce();
            recipe.AddTopings();
            recipe.AddCheese();
            recipe.BakePizza();
            recipe.BoxPizza();
        }
    }
}
