using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_03_Counter
{
    class Counter
    {
        //Create Counter class

        //which has an integer property
        //when creating it should have a default value 0 or we can specify it when creating
        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value

        private int counterNumber;
        private int counterNumberInitial=0;

        public Counter(int counterNumber = 0)
        {
            this.counterNumber = counterNumber;
            this.counterNumberInitial = counterNumber;
        }

        public void Add(int numberToAdd)
        {
            counterNumber += numberToAdd;
        }

        public void Add()
        {
            counterNumber += 1;
        }

        public string Get ()
        {
            return Convert.ToString(counterNumber);
        }

        public void Reset()
        {
            this.counterNumber = counterNumberInitial;
        }
    }
}
