using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            name = "Bass Guitar";
            numberOfStrings = 4;
            soundOfInstrument = "Duum-duum-duum";
        }

        public BassGuitar(int argNumberOfStrings)
        {
            name = "Bass Guitar";
            numberOfStrings = argNumberOfStrings;
            soundOfInstrument = "Duum-duum-duum";
        }

        public override void Play()
        {
            Sound();
        }

    }
}
