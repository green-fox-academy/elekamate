using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_01_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Animal class

            //Every animal has a hunger value, which is a whole number
            //Every animal has a thirst value, which is a whole number
            //when creating a new animal object these values are created with the default 50 value
            //Every animal can eat() which decreases their hunger by one
            //Every animal can drink() which decreases their thirst by one
            //Every animal can play() which increases both by one

            Animal cat = new Animal();
            Console.WriteLine($"ThirstV: {cat.StatusThirst()}, Hunger: {cat.StatusHunger()}");
            cat.Drink();
            Console.WriteLine($"After Drink - ThirstV: {cat.StatusThirst()}, Hunger: {cat.StatusHunger()}");
            cat.Eat();
            Console.WriteLine($"After Eat - ThirstV: {cat.StatusThirst()}, Hunger: {cat.StatusHunger()}");
            cat.Play();
            Console.WriteLine($"After Play - ThirstV: {cat.StatusThirst()}, Hunger: {cat.StatusHunger()}");
            Console.ReadKey();
        }
    }
}
