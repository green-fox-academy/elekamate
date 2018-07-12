using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HeroBattle
{
    public abstract class Hero : BaseHero, IPunchable
    {
        public Hero(string name) : base(name)
        {
        }

        public Hero(string name, int motivation) : base(name)
        {
        }

        public override int GetMotivationLevel()
        {
            if (motivation < 25)
            {
                return 0;
            }
            else if (motivation <= 40)
            {
                return 1;
            }
            else if (motivation > 40)
            {
                return 2;
            }
            return 0;
        }

        public void BePunched(double damage)
        {
            motivation = motivation - (damage / motivation);
        }

        public override void Punch(IPunchable other)
        {
            Hero otherHero = (Hero)other;
            if (motivation>=1 && otherHero.GetType().Name != this.GetType().Name)
            {
                other.BePunched(motivation / 1.5);
            }
        }

        public override string ToString()
        {
            // *-ToString: returns a string status report about the hero
            // *- if the hero's motivation level is 0: {name} is not motivated anymore.
            //* - if the hero's motivation level is 1: {name} is motivated.
            //* - if the hero's motivation level is 2: {name} is well motivated.
            int motivationLevel = GetMotivationLevel();
            string motivationString = "";
            if (motivationLevel == 0)
            {
                motivationString = " is not motivated anymore.";
            }
            if (motivationLevel == 1)
            {
                motivationString = " is motivated.";
            }
            if (motivationLevel == 2)
            {
                motivationString = " is well motivated.";
            }
            return $"{this.GetName()}{motivationString}";
        }
    }
}
