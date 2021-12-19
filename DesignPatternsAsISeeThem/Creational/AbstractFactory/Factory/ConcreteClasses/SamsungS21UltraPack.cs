using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory.FactoryConcreteClasses
{
    public class SamsungS21UltraPack : ISmartPhonePack
    {
        public ISmartPhone AddSmartPhone()
        {
            return new SamsungS21Ultra();
        }

        public ICharger AddCharger()
        {
            return new SamsungCharger();
        }

        public IHandsfree AddHandsfree()
        {
            return new SamsungGalaxyBodsPro();
        }
        public double GetPrice() =>
            AddCharger().GetPrice() +
            AddHandsfree().GetPrice() +
            AddSmartPhone().GetPrice();
    }
}
