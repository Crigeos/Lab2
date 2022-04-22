using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class EnglishSpeaker : iSpeaker
    {
        private string Name { get; set; }
        public EnglishSpeaker(string name)
        {
            Name = name;
        }
        public string Answer(string text)
        {
               
        }

        public string Question(string text)
        {
            
        }
    }
}
