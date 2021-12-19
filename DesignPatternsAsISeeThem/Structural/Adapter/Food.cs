using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Adapter
{
    public class Food : IFood
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public string GetDescription() => $"{Name}: {Ingredients} -----> {Price}$";
    }
}
