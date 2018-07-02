using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Models
{
    public class Fox
    {
        private List<Trick> knownTricks = new List<Trick>();
        public string Name { get; set; }

        public Fox(string name)
        {
            Name = name;
        }

        public void TrickAdd(Trick trickToAdd)
        {
            knownTricks.Add(trickToAdd);
        }

        public List<Trick> GetTricks()
        {
            return knownTricks;
        }

        public int GetNumberOfTricks()
        {
            return knownTricks.Count();
        }
    }
}
