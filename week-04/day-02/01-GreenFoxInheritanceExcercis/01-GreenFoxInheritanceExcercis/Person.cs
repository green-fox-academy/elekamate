using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Person
    {
        private int age;
        private string gender;

        public string Name { get; set; }
        public int Age
        {
            get{ return age; }

            set
            {
                if (value<1 || value>150)
                {
                    Console.WriteLine("Invalid age.");
                }
                else
                {
                    age=value;
                }
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {

            }

        }

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
    }
}
