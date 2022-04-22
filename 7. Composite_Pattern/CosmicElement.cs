using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Composite_Pattern
{
    abstract class CosmicElement
    {
        public abstract void Display(int level);
        public string Name { get; }
        public CosmicElement(string name)
        {
            Name = name;
        }
    }
}
