using DesignPatternsAsISeeThem.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    public class AdapterTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            this.IntroduceTester();

            Menu foodCourtMenu = new Menu();
            Food riceAndChicken = new Food
            {
                Name = "Rice & Chicken",
                Ingredients = "rice,chicken,oil,pepper,salt,saffron,potatoes",
                Price = 24.5
            };

            FastFood bigMac = new FastFood
            {
                Brand = "McDonnald's",
                Name = "Big Mac",
                Items = new List<string>(new string[] { "Beef", "Cheese", "Mushroom", "Fries", "Cola", "Ketchup" }),
                Price = 20.0f
            };

            //this line of code won't compile, because bigMac is not a Food.
            //foodCourtMenu.SetMeals(riceAndChicken, bigMac);

            var adapter = new FastFoodAdapter(bigMac);
            var bigMacFood = adapter.GetFood();
            foodCourtMenu.SetMeals(riceAndChicken, bigMacFood);

            var print = foodCourtMenu.PrintMenu();
            Console.WriteLine(print);
        }
    }
}