using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    public abstract class Instrument
    {
        protected string name;

        abstract public void Play();
    }

}
