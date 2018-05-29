using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Mentor : Person
    {
        private static List<string> levelValues = new List<string>();

        private string level;

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level)
        {
            Name=name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                levelValuesListFill();
                
                if (levelValues.Contains(value) == true)
                {
                    level = value;
                }        
            }
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }

        private static void levelValuesListFill()
        {
            levelValues.Add("junior");
            levelValues.Add("intermediate");
            levelValues.Add("senior");
        }
    }
}
