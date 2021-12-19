using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface
{
    public interface IHandsfree : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
