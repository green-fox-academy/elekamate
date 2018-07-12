using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Program
    {
        public static void Main(string[] args)
        {
            var pirates = new List<Pirate>();
            var filteredPirates = new List<Pirate>();

            // Given this list...
            pirates.Add(new Pirate("Olaf", false, 12));
            pirates.Add(new Pirate("Uwe", true, 9));
            pirates.Add(new Pirate("Jack", true, 16));
            pirates.Add(new Pirate("Morgan", false, 17));
            pirates.Add(new Pirate("Hook", true, 20));

            // Write a function that takes any list that contains pirates as in the example,
            // And returns a list of names containing the pirates that
            // - have wooden leg and
            // - have more than 15 gold
            filteredPirates = FilterPirateList(pirates);
            Console.ReadLine();
        }

        public static List<Pirate> FilterPirateList(List<Pirate> originalPirateList)
        {
            var filteredPirateList = new List<Pirate>();

            foreach (Pirate xPirate in originalPirateList)
            {
                if (xPirate.HasWoodenLeg==true && xPirate.Gold>15)
                {
                    filteredPirateList.Add(xPirate);
                }
            }
            return filteredPirateList;
        }

    }

    class Pirate
    {
        public string Name;
        public bool HasWoodenLeg;
        public int Gold;

        public Pirate(string name, bool hasWoodenLeg, int gold)
        {
            Name = name;
            HasWoodenLeg = hasWoodenLeg;
            Gold = gold;
        }

    }
}
