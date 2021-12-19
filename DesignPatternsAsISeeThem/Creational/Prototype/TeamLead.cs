using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Prototype
{
    public class TeamLead : Developer
    {
        public byte CommunicationSkills { get; set; }
        public byte DomainKnowledge { get; set; }

        public TeamLead(Developer developer)
        {
            this.Name = developer.Name;
            this.Stack = developer.Stack;
        }

        public new TeamLead Clone()
        {
            var clone = new TeamLead(base.Clone());
            clone.CommunicationSkills = this.CommunicationSkills;
            clone.DomainKnowledge = this.DomainKnowledge;
            return clone;
        }
    }
}
