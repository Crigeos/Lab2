using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Composite_Pattern
{
    class Star : CosmicElement
    {
        //private int _size;

        public Star(string name) : base(name)
        {
        }

        public override void Display(int level)
        {
            string spaces = new string('\t', level);
            Console.WriteLine(spaces + "   *   ");
            Console.WriteLine(spaces + "  * *  ");
            Console.WriteLine(spaces + " *   *   - " + Name);
            Console.WriteLine(spaces + "  * *  ");
            Console.WriteLine(spaces + "   *   ");
        }
    }
}
