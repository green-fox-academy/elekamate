using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_02_Comparable
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            dominoes.Sort();
            Console.WriteLine(PrintOrder(dominoes));
            Console.ReadLine();
        }

        private static string PrintOrder(List<Domino> argDominoes)
        {
            string outputString = "";
            foreach (Domino xDomino in argDominoes)
            {
                outputString += $"[{xDomino.GetValues()[0]}, {xDomino.GetValues()[1]}], ";
            }
            return outputString.Substring(0, outputString.Length - 2);
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

    }
}
