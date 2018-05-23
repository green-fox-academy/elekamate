using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ComplexArchs_01_TeachStuden
{
    class Student
    {
        //Student
        //    learn()
        //    question(teacher)->calls the teachers answer method

        private string name;
        public Student(string name)
        {
            this.Name = name;
        }
        public string Name { get => name; set => name = value; }

        public void Learn()
        {
            Console.WriteLine(this.Name+" is learning"); 
        }

        public void Question(Teacher teacher)
        {
            Console.WriteLine(Name + " is asking teacher " + teacher.Name + ".");
            teacher.Answer();
        }
    }
}
