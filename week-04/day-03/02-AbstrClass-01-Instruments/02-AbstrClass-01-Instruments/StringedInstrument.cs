using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    abstract class StringedInstrument : Instrument
    {
        int numberOfStrings;

        abstract public void Sound();
    }
}
