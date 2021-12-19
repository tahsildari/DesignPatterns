using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class SamsungGalaxyBodsPro : IHandsfree
    {
        public string Name { get; set; } = "Galaxy Buds Pro, Phantom Black";
        public double Price { get; set; } = 199.99;
        public double GetPrice() => Price;
    }
}
