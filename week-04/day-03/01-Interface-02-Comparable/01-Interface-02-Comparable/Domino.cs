using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_02_Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino argOtherDomino)
        {
            return Values[0].CompareTo(argOtherDomino.Values[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }

    }
}
