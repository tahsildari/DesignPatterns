using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Factory
{
    public class LandTransport : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
