using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Composite
{
    public abstract class Node
    {
        public Node(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Display();
        public abstract string DisplayWithSize();
        public abstract int GetSize();
    }
}
