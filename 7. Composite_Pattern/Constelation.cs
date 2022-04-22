using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Composite_Pattern
{
    class Constelation : CosmicElement
    {
        private List<CosmicElement> _constelations = new List<CosmicElement>();
        public Constelation(string name) : base(name)
        {
        }

        public override void Display(int level = 0)
        {
            string spaces = new string('\t', level);
            Console.WriteLine(spaces + "└ " + Name);
            foreach (var c in _constelations)
            {
                
                //Console.WriteLine(spaces + "└ ");
                c.Display(level + 1);
            }
        }
        public void AddElement(CosmicElement _cosmicElement)
        {
            _constelations.Add(_cosmicElement);
        }
        public void RemoveElement(CosmicElement _cosmicElement)
        {
            _constelations.Remove(_cosmicElement);
        }

    }
}
