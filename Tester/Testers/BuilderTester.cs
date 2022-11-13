using DesignPatternsAsISeeThem.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    class BuilderTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            IntroduceTester();

            List<Pizza> pizzas = new List<Pizza>();

            Restaurant dominos = new Restaurant();
            
            PizzaRecipe hotPepperoni = new HotPepperoniPizzaBuilder();
            PizzaRecipe normalPepperoni = new PepperoniPizzaBuilder();
            PizzaRecipe homeMargaritta = new HomeItalianMargarittaPizzaBuilder();

            dominos.SetBuilder(hotPepperoni);
            dominos.MakePizza();
            pizzas.Add(dominos.GetPizza());

            dominos.SetBuilder(normalPepperoni);
            dominos.MakePizza();
            pizzas.Add(dominos.GetPizza());

            dominos.SetBuilder(homeMargaritta);
            dominos.MakePizza();
            pizzas.Add(dominos.GetPizza());

            pizzas.ForEach(p =>
                Console.WriteLine(p.ToString()));
        }
    }
}
