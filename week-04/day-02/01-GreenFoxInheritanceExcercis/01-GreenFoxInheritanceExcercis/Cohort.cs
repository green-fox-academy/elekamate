using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GreenFoxInheritanceExcercis
{
    class Cohort
    {
        // Properties
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        // Constructures
        public Cohort(string name)
        {
            Name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        // Methods
        public void AddStudent(Student argStudent)
        {
            Students.Add(argStudent);
        }

        public void AddMentor(Mentor argMentor)
        {
            Mentors.Add(argMentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {Students.Count()} students and {Mentors.Count}  mentors.");
        }

    }
}
