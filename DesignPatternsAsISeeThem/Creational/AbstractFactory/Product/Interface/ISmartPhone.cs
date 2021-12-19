using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface
{
    public interface ISmartPhone : IProduct
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public int CameraMegaPixels { get; set; }

    }
}
