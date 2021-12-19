using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public abstract class PizzaRecipe
    {
        protected Pizza pizza;
        public void Reset() => pizza = new Pizza();
        public Pizza GetPizza() => pizza;
        public abstract void PrepareDough();
        public abstract void AddSauce();
        public abstract void AddTopings();
        public abstract void AddCheese();
        public abstract void BakePizza();
        public abstract void BoxPizza();

    }
}
