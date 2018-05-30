using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_02_Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object argOtherDomino)
        {
            Domino otherDomino = (Domino)argOtherDomino;
            return this.CompareTo(otherDomino.Values[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }

    }
}
