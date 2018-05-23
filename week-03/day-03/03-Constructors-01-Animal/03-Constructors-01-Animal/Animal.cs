using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_01_Animal
{
    class Animal
    {
        //Create an Animal class

        //Every animal has a hunger value, which is a whole number
        //Every animal has a thirst value, which is a whole number
        //when creating a new animal object these values are created with the default 50 value
        //Every animal can eat() which decreases their hunger by one
        //Every animal can drink() which decreases their thirst by one
        //Every animal can play() which increases both by one
        private int hungerValue;
        private int thirstValue;

        public Animal()
        {
            hungerValue = 50;
            thirstValue = 50;
        }

        public void Eat()
        {
            hungerValue--;
        }

        public void Drink()
        {
            thirstValue--;
        }

        public void Play()
        {
            hungerValue++;
            thirstValue++;
        }

        public int StatusHunger()
        {
            return hungerValue;
        }
        public int StatusThirst()
        {
            return thirstValue;
        }
    }
}
