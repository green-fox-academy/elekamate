using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Models
{
    public class Trick
    {
        public string Name { get; set; }

        public Trick(string name)
        {
            Name = name;
        }
    }
}
