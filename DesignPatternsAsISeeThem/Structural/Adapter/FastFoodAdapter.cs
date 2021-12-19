using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Adapter
{
    //Adapter class that helps us work with FastFood as a Food
    public class FastFoodAdapter : Food
    {
        private FastFood fastFood;

        public FastFoodAdapter(FastFood fastFood)
        {
            this.fastFood = fastFood;
        }

        public Food GetFood()
        {
            this.Name = fastFood.Name;
            this.Price = fastFood.Price * 1.1D; //10% profit
            this.Ingredients = string.Join(',', fastFood.Items.Select(item => item.ToLower()));
            return this;
        }
    }
}
