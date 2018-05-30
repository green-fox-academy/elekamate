using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_02_Comparable
{
    class Thing : IComparable<Thing>
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public int CompareTo(Thing other)
        {
            return this.Completed.CompareTo(other.Completed);
        }

        public void Complete()
        {
            this.Completed = true;
        }

    }
}
