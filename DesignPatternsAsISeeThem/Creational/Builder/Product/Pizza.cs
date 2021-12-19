using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Builder
{
    public class Pizza
    {
        public string sauce = "";
        public string toppings = "";
        public string cheese = "";
        public bool baked = false;
        public bool boxed = false;
        public Dough dough = Dough.StoreBought;
        public Size size = Size.American;

        public override string ToString()
        {
            return 
                $"{dough} bread ({size}), {cheese}, {sauce}"
                + $", with {toppings}, {(baked ? "baked" : "raw")}"
                + $" and {(boxed ? "boxed" : "vaccumed")}";
        }
    }

    public enum Dough
    {
        StoreBought,
        HomeMade
    }

    public enum Size
    {
        American,
        Italian
    }
}
