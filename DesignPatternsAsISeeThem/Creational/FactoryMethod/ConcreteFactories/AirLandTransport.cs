using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Factory
{
    public class AirLandTransport : ITransportFactory
    {
        public bool QuickestPreffered { get; set; }
        public ITransport CreateTransport()
        {
            Console.WriteLine("AirLandTransport with less "
                + (QuickestPreffered ? "delivery time" : "costs")
                + " => ");

            return QuickestPreffered
                ? new Airplane()
                : new Truck();
        }
    }
}
