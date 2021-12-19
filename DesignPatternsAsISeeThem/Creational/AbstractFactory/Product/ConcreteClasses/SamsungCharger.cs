using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class SamsungCharger : ICharger
    {
        public bool Wireless { get; set; } = true;
        public int Watts { get; set; } = 15;
        public double Price { get; set; } = 199;
        public double GetPrice() => Price;
    }
}
