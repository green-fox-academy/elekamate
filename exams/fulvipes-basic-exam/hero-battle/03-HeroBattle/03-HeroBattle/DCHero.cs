using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HeroBattle
{
    class DCHero : Hero
    {
        public DCHero(string name) : base(name)
        {
            motivation = 45;
            heroUniverse = "DC";
        }

        public DCHero(string name, int motivation) : base(name, motivation)
        {
            this.name = name;
            this.motivation = motivation;
            heroUniverse = "DC";
        }
    }
}
