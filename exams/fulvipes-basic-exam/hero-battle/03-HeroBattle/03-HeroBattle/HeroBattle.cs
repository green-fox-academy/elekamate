using System;
using System.Collections.Generic;

namespace _03_HeroBattle
{
    public class HeroBattle
    {
        /**
        * In this file we want to simulate a fight between Superheroes.
        * Please implement the necessary classes by the following specification
        *
        * You will need a Hero class which is also a BaseHero and is an IPunchable (these are provided to you)
        * It should have the following:
        *
        * Properties
        * - motivation: a number representing how much the hero wants to save the world
        *
        * Methods
        * - constructor: sets the hero's name and motivation
        *
        * - GetMotivationLevel: returns a number between 0 and 2
        * - 0 if the motivation below 25
        * - 1 if the motivation between 25 and 40
        * - 2 if motivation is above 40
        *
        * - Punch: take damage on the other hero by using his/her bePunched function
        * - damage = the puncher hero's motivation / 1.5
        * - the hero punches other heroes only if his/her motivation level is at least 1
        *
        * - BePunched: suffer damage, calculated like:
        * - motivation = motivation - (damage / motivation)
        *
        * - ToString: returns a string status report about the hero
        * - if the hero's motivation level is 0: {name} is not motivated anymore.
        * - if the hero's motivation level is 1: {name} is motivated.
        * - if the hero's motivation level is 2: {name} is well motivated.
        *
        * You will need also a DCHero and a MarvelHero classes. They extend the Hero class
        * with a restriction, they cannot punch other heroes from the same "Universe":
        * - A MarvelHero shouldn't be able to punch another MarvelHero
        * - A DCHero shouldn't be able to punch another DCHero
        * Also they should have a default motivation if only the name is provided when we create them. Default values:
        * - MarvelHero: 40
        * - DCHero: 45
        * You don't need to modify this file, just add your imports to it.
        */

        public HeroBattle()
        {
                
        }
        
        public static void Main(string[] args)
        {
            /*********************************************************
            *  Do not modify the code below except for test purpose *
            *********************************************************/

            List<BaseHero> heroes = new List<BaseHero>{
                new MarvelHero("Hulk", 55),
                new MarvelHero("Iron man", 35),
                new MarvelHero("Daredevil"),
                new DCHero("Batman", 60),
                new DCHero("Superman", 25),
                new DCHero("Wonder woman")
            };
            
            Battle(heroes);

            Log(heroes);
            Console.ReadLine();
        }

        private static void Battle(List<BaseHero> heroes)
        {
            while (AnyHeroCanFight(heroes))
            {
                foreach (BaseHero hero in heroes)
                {
                    PunchOtherHeroes(hero, heroes);
                }
            }
        }

        private static void Log(List<BaseHero> heroes)
        {
            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero); ;
            }
        }
        
        private static bool AnyHeroCanFight(List<BaseHero> heroes)
        {
            foreach (BaseHero hero in heroes)
            {
                if (hero.GetMotivationLevel() > 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static void PunchOtherHeroes(BaseHero hero, List<BaseHero> otherHeroes)
        {
            foreach (BaseHero otherHero in otherHeroes)
            {
                if (otherHero != hero && otherHero is IPunchable) {
                    hero.Punch((IPunchable)otherHero);
                }
            }
        }
    }
}
