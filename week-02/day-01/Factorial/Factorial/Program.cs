using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            int numberToFactorial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorio(numberToFactorial));

            Console.ReadLine();
        }

        static int Factorio(int arg_numberToFactorial)
        {
            int resultOfFactorial = 1;

            for (int i = 1; i < arg_numberToFactorial+1; i++)
            {
                resultOfFactorial *= i;
            }

            return resultOfFactorial;
        }
    }
}
