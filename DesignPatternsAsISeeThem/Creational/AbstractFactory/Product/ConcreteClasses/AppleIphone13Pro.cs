using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public class AppleIphone13Pro : ISmartPhone
    {
        public string Model { get; set; } = "IPhone 13 Pro";
        public double Price { get; set; } = 1_299.99;
        public int CameraMegaPixels { get; set; } = 12;
        public double GetPrice() => Price;
    }
}
