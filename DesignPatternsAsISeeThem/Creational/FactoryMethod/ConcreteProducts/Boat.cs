using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Factory
{
    public class Boat : ITransport
    {
        public string Deliver()
        {
            return "Cargo will be delivered via sea.";
        }
    }
}
