using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            name = "Electric Guitar";
            numberOfStrings = 6;
            soundOfInstrument = "Twang";
        }

        public ElectricGuitar(int argNumberOfStrings)
        {
            name = "Electric Guitar";
            numberOfStrings = argNumberOfStrings;
            soundOfInstrument = "Twang";
        }

        public override void Play()
        {
            Sound();
        }

    }
}
