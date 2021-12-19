using DesignPatternsAsISeeThem.Creational.Factory;
using System;
using System.Collections.Generic;
using Tester.Testers;

namespace Tester
{
    class Program
    {
        public static List<ITester> testers = new List<ITester>();
        static void Main(string[] args)
        {
            testers.Add(new FactoryMethodTester());
            testers.Add(new AbstractFactoryTester());
            testers.Add(new BuilderTester());
            testers.Add(new PrototypeTester());
            testers.Add(new SingletonTester());
            testers.Add(new AdapterTester());

            testers.ForEach(t => t.Run());

            Console.ReadLine();
        }
    }
}
