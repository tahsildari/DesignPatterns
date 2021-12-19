using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Prototype
{
    public class Developer : IDeveloper
    {
        public string Name { get; set; }
        public Stack Stack { get; set; }

        public Developer Clone()
        {
            return new Developer
            {
                Name = this.Name,
                Stack = new Stack
                {
                    BackEnd = this.Stack.BackEnd,
                    FrontEnd = this.Stack.FrontEnd,
                    Database = this.Stack.Database
                }
            };
        }
    }
}
