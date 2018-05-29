using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Sponsor : Person
    {
        // Properties
        private int HiredStudents { get; set; }
        private string Company { get; set; }

        // Constructures
        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
            HiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company)
        {
            HiredStudents = 0;
            Name = name;
            Age = age;
            Gender = gender;
            Company = company;
        }

        // Methods
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old gender who represents {Company} and hired {HiredStudents} students so far.");
        }

        public void Hire()
        {
            HiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

    }
}
