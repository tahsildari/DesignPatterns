using DesignPatternsAsISeeThem.Creational.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    public class PrototypeTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            IntroduceTester();

            IDeveloper mat2015 = new Developer
            {
                Name = "Mat Sparkles",
                Stack = new Stack
                {
                    BackEnd = "C#, .Net Framework 4.0"
                }
            };

            IDeveloper mat2018 = mat2015.Clone();
            mat2018.Name += " Scorch"; //Married :D
            mat2018.Stack.FrontEnd = "React, Html5, CSS3";
            mat2018.Stack.Database = "MSSQL, Redis";

            TeamLead matLead2020 = new TeamLead(mat2018.Clone());
            matLead2020.CommunicationSkills = 73;
            matLead2020.DomainKnowledge = 48;

            TeamLead matLead2022 = matLead2020.Clone();
            matLead2022.CommunicationSkills += 17;
            matLead2022.DomainKnowledge += 22;

            //We print them in reverse order to spot mistakes
            Console.WriteLine($"{matLead2022.Name}: {matLead2022.Stack.BackEnd} | {matLead2022.Stack.Database} | {matLead2022.Stack.FrontEnd} (comm. {matLead2022.CommunicationSkills}/100 & domain {matLead2022.DomainKnowledge}/100)");
            Console.WriteLine($"{matLead2020.Name}: {matLead2020.Stack.BackEnd} | {matLead2020.Stack.Database} | {matLead2020.Stack.FrontEnd} (comm. {matLead2020.CommunicationSkills}/100 & domain {matLead2020.DomainKnowledge}/100)");
            Console.WriteLine($"{mat2018.Name}: {mat2018.Stack.BackEnd} | {mat2018.Stack.Database} | {mat2018.Stack.FrontEnd} ");
            Console.WriteLine($"{mat2015.Name}: {mat2015.Stack.BackEnd} | {mat2015.Stack.Database} | {mat2015.Stack.FrontEnd} ");

            TeamLead badCopy = matLead2022;
            badCopy.Name = "Mat Sparkles divorced";

            Console.WriteLine($"After divorce his name changed from '{matLead2022.Name}' to '{badCopy.Name}' - oh oh, that's the mess references make, we expected different names !!!");
        }
    }
}
