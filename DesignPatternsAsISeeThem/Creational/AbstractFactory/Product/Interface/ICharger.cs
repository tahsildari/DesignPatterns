using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface
{
    public interface ICharger : IProduct
    {
        public bool Wireless { get; set; }
        public int Watts { get; set; }
        public double Price { get; set; }

    }
}
