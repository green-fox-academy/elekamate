using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower yellowFlower = new Flower("yellow");
            Flower blueFlower = new Flower("blue");

            Tree purpleTree = new Tree("purple");
            Tree orangeTree = new Tree("orange");


            Console.ReadKey();
        }
    }
}
