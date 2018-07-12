using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class that represents a cuboid:
            // It should take its three dimensions as constructor parameters (numbers)
            // It should have a method called `GetSurface` that returns the cuboid's surface
            // It should have a method called `GetVolume` that returns the cuboid's volume

            Cuboid cube = new Cuboid(2,2,2);
            Cuboid rectangle = new Cuboid(2,3,4);

            Console.WriteLine($"rectangle surface: {rectangle.GetSurface()}");
            Console.WriteLine($"cube surface: {cube.GetSurface()}");
            Console.WriteLine($"rectangle volume: {rectangle.GetVolume()}");
            Console.WriteLine($"cube volume: {cube.GetVolume()}");
            Console.ReadKey();
        }

    }
}