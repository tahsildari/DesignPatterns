using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory.FactoryConcreteClasses
{
    public class IPhone13ProPack : ISmartPhonePack
    {
        public ISmartPhone AddSmartPhone()
        {
            return new AppleIphone13Pro();
        }

        public ICharger AddCharger()
        {
            return new AppleCharger();
        }

        public IHandsfree AddHandsfree()
        {
            return new AppleAirPodsPro();
        }

        public double GetPrice() =>
            AddCharger().GetPrice() +
            AddHandsfree().GetPrice() +
            AddSmartPhone().GetPrice();

    }
}
