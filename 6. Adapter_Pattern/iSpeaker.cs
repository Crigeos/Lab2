using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    interface iSpeaker
    {
        string Question(string text);
        string Answer(string text);
    }
}
