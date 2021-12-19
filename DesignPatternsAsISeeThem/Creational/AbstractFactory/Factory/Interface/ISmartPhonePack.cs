using DesignPatternsAsISeeThem.Creational.AbstractFactory.Interface;

namespace DesignPatternsAsISeeThem.Creational.AbstractFactory
{
    public interface ISmartPhonePack : IProduct
    {
        public ISmartPhone AddSmartPhone();
        public ICharger AddCharger();
        public IHandsfree AddHandsfree();
        public double GetPrice();

    }
}
