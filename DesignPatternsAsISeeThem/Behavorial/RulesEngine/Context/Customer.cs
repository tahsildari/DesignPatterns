using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Behavorial.RulesEngine.Context
{
    public class Customer
    {
        public DateTime Birthdate { get; set; }
        public DateTime? DateOfFirstPurchase { get; set; }
        public bool IsTeacher { get; set; }
    }
}
