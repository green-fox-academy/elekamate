using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            int baseN = Int32.Parse(Console.ReadLine());
            int powerN = Int32.Parse(Console.ReadLine());
            Console.WriteLine(PowerN(baseN,powerN));
            Console.ReadKey();
        }

        public static int PowerN(int argbaseN, int argpowerN)
        {
            if (argpowerN == 1)
            {
                return argbaseN;
            }
            else
            {
                return argbaseN * PowerN(argbaseN, argpowerN - 1);
            }
        }

    }
}
