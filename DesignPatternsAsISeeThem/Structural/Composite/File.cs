using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Composite
{
    public class File : Node
    {
        public File(string name, int size) : base(name)
        {
            Size = size;
        }

        public int Size { get; }

        public override string Display()
        {
            return $"-- {Name} [F]";
        }

        public override string DisplayWithSize()
        {
            return $"-- {Name} ({Size} KB) [F]";
        }

        public override int GetSize()
        {
            return Size;
        }
    }
}
