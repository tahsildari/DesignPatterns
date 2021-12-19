using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Singleton
{
    public class Logger
    {
        private List<string> history;

        public Logger()
        {
            history = new List<string>();
        }

        public void Log(string message) => history.Add($"{message} [obj: {this.GetHashCode()}]");
        public string GetHistory() => string.Join(" :: ", history.ToArray());

       
    }
}
