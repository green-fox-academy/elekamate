using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_02_Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Sharpie class
            //    We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
            //    When creating one, we need to specify the Color and the Width
            //    Every sharpie is created with a default 100 as InkAmount
            //    We can Use() the sharpie objects
            //        which decreases inkAmount

            Sharpie sharpie1 = new Sharpie("red", 20,50);
            sharpie1.Use();

            Console.ReadKey();
        }
    }
}
