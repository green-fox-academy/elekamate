using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int cuboid_a = Int32.Parse(Console.ReadLine());
            int cuboid_b = Int32.Parse(Console.ReadLine());
            int cuboid_c = Int32.Parse(Console.ReadLine());

            double cuboid_Surface=(cuboid_a *  cuboid_b +  cuboid_a *  cuboid_c +  cuboid_b *  cuboid_c)*2;
            double cuboid_Volume= cuboid_a* cuboid_b * cuboid_c;

            Console.WriteLine("Surface Area: {0}", cuboid_Surface);
            Console.WriteLine("Volume: {0}", cuboid_Volume);

            Console.ReadLine();
        }
    }
}
