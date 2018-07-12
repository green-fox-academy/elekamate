using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HeroBattle
{
    public class MarvelHero : Hero
    {
        public MarvelHero(string name) : base(name)
        {
            motivation = 40;
            heroUniverse = "Marvel";
        }
        
        public MarvelHero(string name, int motivation) : base (name,motivation)
        {
            this.name = name;
            this.motivation = motivation;
            heroUniverse = "Marvel";
        }
    }
}
