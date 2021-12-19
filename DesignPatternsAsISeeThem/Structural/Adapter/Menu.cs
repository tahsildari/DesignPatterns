using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Adapter
{
    public class Menu
    {
        List<Food> availableMeals = new List<Food>();
        
        public void SetMeals(params Food[] meals) {
            availableMeals.AddRange(meals);
        }

        public string PrintMenu() => string.Join(Environment.NewLine, availableMeals.Select(m => m.GetDescription()));
    }
}
