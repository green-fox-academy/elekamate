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

        public Student(string name, int age, string gender, string previousOrganization) 
            : base(name,age,gender)
        {
            SkippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }


        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

    }
}
