using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ConditionalVariableMuta
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////  1
            decimal a = 24;
            int out1 = 0;
            // if a is even increment out by one
            if (a % 2 == 0)
            {
                out1 += 1;
            }

            Console.WriteLine(out1);

            //////////////////////////////////////////////////////////////////////////////////  2
            int b = 21;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            if (b<10)
            {
                Console.WriteLine("Less!");
            }
            else if (b<=20)
            {
                Console.WriteLine("Sweet!");
            }
            else
            {
                Console.WriteLine("More!");        
            }

            Console.WriteLine(out2);

            //////////////////////////////////////////////////////////////////////////////////  3
            int c = 123;
            int credits = 49;
            bool isBonus = true;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (isBonus==false)
            {
                if (credits>=50)
                {
                    c -= 2;
                }
                else
                {
                    c -= 1;
                }
            }

            Console.WriteLine(c);

            //////////////////////////////////////////////////////////////////////////////////  4
            int d = 9;
            int time = 121;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if (time>200)
            {
                out3 = "Time out";
            }
            else if (d % 4 == 0)
            {
                out3 = "check";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);

            //////////////////////////////////////////////////////////////////////////////////  5
            Console.ReadLine();
        }
    }
}
