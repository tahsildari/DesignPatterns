using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class SamsungS21Ultra : ISmartPhone
    {
        public string Model { get; set; } = "Galaxy S21 Ultra";
        public double Price { get; set; } = 1_199;
        public int CameraMegaPixels { get; set; } = 108;
        public double GetPrice() => Price;
    }
}
