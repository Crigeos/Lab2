using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Composite_Pattern
{
    class Progam
    {
        static void Main(string[] args)
        {
            Constelation Constelation_1 = new Constelation("Calea Lactee");
            Star Star_1 = new Star("Bear");
            Planet Planet_1 = new Planet("Earth");
            Constelation_1.AddElement(Star_1);
            Constelation_1.AddElement(Planet_1);
            Constelation Constelation_2 = new Constelation("Solar System");
            Planet Planet_2 = new Planet("Uran");
            Constelation_1.AddElement(Constelation_2);
            Constelation_1.Display();
        }
    }
}