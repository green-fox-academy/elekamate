using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_01_Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentJack = new Student("John", 20, "male", "BME");
            Student studentJoe = (Student)studentJack.Clone();
            Console.ReadLine();
        }

    }
}
