using DesignPatternsAsISeeThem.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using Tester.Testers;

namespace Tester
{
    class Program
    {
        public static List<ITester> testers = new List<ITester>();
        static void Main(string[] args)
        {
            LoadTestersDynamically();

            testers.ForEach(t => t.Run());

            Console.ReadLine();
        }

        private static void LoadTestersDynamically()
        {
            AppDomain.CurrentDomain.GetAssemblies()
                            .SelectMany(@assembly => @assembly.GetTypes())
                            .Where(@class => typeof(ITester).IsAssignableFrom(@class) && @class.IsClass)
                            .ToList()
                            .ForEach(@tester => testers.Add((ITester)Activator.CreateInstance(@tester)));
        }
    }
}
