using System;

namespace _03_HeroBattle
{
    public abstract class BaseHero
    {
        protected string name;
        protected double motivation;
        protected string heroUniverse;

        public BaseHero(String name)
        {
            this.name = name;
            heroUniverse = GetType().Name;
        }
        
        public abstract void Punch(IPunchable other);

        public abstract int GetMotivationLevel();

        public string GetName()
        {
            return name;
        }

        public string GetHeroUniverse()
        {
            return heroUniverse;
        }
    }
}
