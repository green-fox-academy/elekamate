using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            //variables
            string MyName = "Mate Elek";
            uint age = 27;
            double height=1.82;
            bool married=false;

            //core
            Console.WriteLine(MyName);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(married);


            Console.ReadLine();
        }
    }
}
