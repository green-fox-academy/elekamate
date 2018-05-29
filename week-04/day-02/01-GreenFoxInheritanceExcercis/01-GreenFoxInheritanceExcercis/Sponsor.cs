using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Sponsor : Person
    {
        private int hiredStudents;
        private string  company;


        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far.");
        }
    }
}
