using System;

namespace FulvipesFoundationExam
{
    public abstract class BaseHero
    {
        private String name;

        public BaseHero(String name)
        {
            this.name = name;
        }
        
        public abstract void Punch(IPunchable other);

        public abstract int GetMotivationLevel();

        public String GetName()
        {
            return name;
        }

    }
}
