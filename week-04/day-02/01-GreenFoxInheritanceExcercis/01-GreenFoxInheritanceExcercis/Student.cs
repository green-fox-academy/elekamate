using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Student : Person
    {
        public int SkippedDays { get; set; }
        public string PreviousOrganization { get; set; }

        public Student(name, age, gender, previousOrganization)
        {
            skippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
            


            sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0
        }


        public GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public Introduce()
        {
            Console.WriteLine("Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
