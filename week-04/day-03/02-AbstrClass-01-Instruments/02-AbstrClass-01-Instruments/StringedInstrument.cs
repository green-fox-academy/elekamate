using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstrClass_01_Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected string soundOfInstrument;
        protected int numberOfStrings;
        public void Sound()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {soundOfInstrument}"); 
        }

    }
}
