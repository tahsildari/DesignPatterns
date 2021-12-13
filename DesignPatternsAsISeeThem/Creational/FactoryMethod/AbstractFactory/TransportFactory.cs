using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Factory
{
    public abstract class TransportFactory : ITransportFactory
    {
        public abstract ITransport CreateTransport();

    }
}
