using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class AppleCharger : ICharger
    {
        public bool Wireless { get; set; } = false;
        public int Watts { get; set; } = 20;
        public double Price { get; set; } = 299;
        public double GetPrice() => Price;
    }
}
