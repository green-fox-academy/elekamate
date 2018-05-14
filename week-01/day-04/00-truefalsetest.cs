using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //true, false
            Console.WriteLine(true);
            Console.WriteLine(false);

            //negation
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            //or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.ReadLine();
        }
    }
}
