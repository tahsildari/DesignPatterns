using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public abstract class Tester
    {
        protected abstract string GetName();
        protected void IntroduceTester()
        {
            var spacer = new string('_', 30);
            Console.WriteLine($"\n{spacer} {GetName()} {spacer}");
        }
    }
}
