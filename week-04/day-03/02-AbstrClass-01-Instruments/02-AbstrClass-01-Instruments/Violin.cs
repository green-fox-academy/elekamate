using System;
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
            NumberOfStrings = 4;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }

    }
}
