using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ComplexArchs_01_TeachStuden
{
    class Teacher
    {
        //Teacher
        //    teach(student)->calls the students learn method
        //    answer()

        private string name;
        public string Name { get => name; set => name = value; }
        public Teacher(string name)
        {
            this.name = name;
        }

        public void Teach(Student student)
        {
            Console.WriteLine(name + " is teaching student " + student.Name + ".");
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine(name+" teacher has answered.");
        }
    }
}
