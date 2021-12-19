﻿using DesignPatternsAsISeeThem.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    public class FactoryMethodTester : ITester
    {
        public void Run() {
            var logisicsCompanies = new List<ITransportFactory>();
            logisicsCompanies.Add(new LandTransport());
            logisicsCompanies.Add(new AirTransport());
            logisicsCompanies.Add(new SeaTransport());
            logisicsCompanies.Add(new AirLandTransport());
            logisicsCompanies.Add(new AirLandTransport { QuickestPreffered = true });

            logisicsCompanies.ForEach(logistic =>
            {
                var transport = logistic.CreateTransport();
                Console.WriteLine(transport.Deliver());
            });
        }
    }
}
