using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Singleton
{
    // In a real-world implementation, this should not exist.
    // The logger should not have any instantiation except the Signleton one.
    public class NormalLogger
    {
        public static Logger GetLogger() => new Logger();
    }
}
