using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_03_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Counter class

            //which has an integer property
            //when creating it should have a default value 0 or we can specify it when creating
            //we can Add(number) to this counter another whole number
            //or we can Add() without parameters just increasing the counter's value by one
            //and we can Get() the current value as string
            //also we can Reset() the value to the initial value

            Counter counter1 = new Counter();
            Console.WriteLine(counter1.Get());
            counter1.Add(5);
            Console.WriteLine(counter1.Get());
            counter1.Add();
            Console.WriteLine(counter1.Get());
            counter1.Reset();
            Console.WriteLine(counter1.Get());

            Console.ReadKey();
        }
    }
}
