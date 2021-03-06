﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
            soundOfInstrument = "Screech";
        }

        public Violin(int argNumberOfStrings)
        {
            name = "Violin";
            numberOfStrings = argNumberOfStrings;
            soundOfInstrument = "Screech";
        }

        public override void Play()
        {
            Sound();
        }

    }
}
