using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class AppleAirPodsPro : IHandsfree
    {
        public string Name { get; set; } = "AirPods Pro";
        public double Price { get; set; } = 249;
        public double GetPrice() => Price;
    }
}
