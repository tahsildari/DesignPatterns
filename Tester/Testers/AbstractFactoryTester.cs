using DesignPatternsAsISeeThem.Creational.AbstractFactory;
using DesignPatternsAsISeeThem.Creational.AbstractFactory.FactoryConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    public class AbstractFactoryTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;

        public void Run()
        {
            this.IntroduceTester();

            ISmartPhonePack applePack = new IPhone13ProPack();
            var applePrice = applePack.GetPrice();

            ISmartPhonePack samsungPack = new SamsungS21UltraPack();
            var samsungPrice = samsungPack.GetPrice();

            Console.WriteLine($"Apple costs {applePrice} while Samsung is cheaper, around {samsungPrice}");

        }
    }
}
