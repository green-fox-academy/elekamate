using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Garden
    {
        // Properties
        public static List<Flower> Flowers { get; set; }
        public static List<Tree> Trees { get; set; }

        // Constructors
        public Garden()
        {
            Flowers = new List<Flower>();
            Trees = new List<Tree>();
        }

        // Methods
        public void ShowTheGarden()
        {
            Console.WriteLine($"Number of trees: {Trees.Count} /n Number of flowers: {Flowers.Count}");
        }

    }
}
