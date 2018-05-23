using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ComplexArchs_01_TeachStuden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Student and Teacher classes
            //Student
            //    learn()
            //    question(teacher)->calls the teachers answer method
            //Teacher
            //    teach(student)->calls the students learn method
            //    answer()

            Teacher t1 = new Teacher("t1");
            Teacher t2 = new Teacher("t2");
            Teacher t3 = new Teacher("t3");

            Student s1 = new Student("s1");
            Student s2 = new Student("s2");
            Student s3 = new Student("s3");

            t1.Teach(s2);
            s3.Question(t2);

            Console.ReadKey();
        }
    }
}
