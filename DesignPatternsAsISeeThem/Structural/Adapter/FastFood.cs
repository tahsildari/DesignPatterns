using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Adapter
{
    //Service class that does not match Client Interface and we can't change, for example a 3rd party class, or a class under use
    public class FastFood
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public List<string> Items { get; set; }
        public float Price { get; set; }
    }
}
