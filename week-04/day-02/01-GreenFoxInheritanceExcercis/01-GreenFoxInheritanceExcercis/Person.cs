using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    public class Person
    {
        // Fields
        private int age;
        private string gender;

        // Properties
        public string Name { get; set; }

        public int Age
        {
            get{ return age; }

            set
            {
                if (value < 1 || value > 150)
                {
                    Console.WriteLine("Invalid age.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if ( value == "male" || value == "female" )
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine( "Invalid gender value." );
                }
            }
        }

        // Construcures
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }

        // Methods
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
