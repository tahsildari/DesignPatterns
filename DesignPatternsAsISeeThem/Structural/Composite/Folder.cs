using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Structural.Composite
{
    public class Folder : Node
    {
        public List<Node> Nodes { get; } = new List<Node>();

        public Folder(string name) : base(name)
        {
        }

        public override string Display()
        {
            var text = $"-- {Name} [D]";
            Nodes.ForEach(n => text += ($"\n{n.Display().Replace("--", "----")}"));
            return text;
        }

        public override string DisplayWithSize()
        {
            var totalSize = GetSize();
            var text = $"-- {Name} ({totalSize} KB) [D]";
            Nodes.ForEach(n => text += ($"\n{n.DisplayWithSize().Replace("--", "----")}"));
            return text;
        }

        public override int GetSize()
        {
            return Nodes.Sum(n => n.GetSize());
        }

        public void Remove(Node node)
        {
            Nodes.Remove(node);
        }

        public void Add(Node node)
        {
            Nodes.Add(node);
        }

    }
}
