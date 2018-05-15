using System;
using System.Text;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            example = example.Replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away


            ////////////////////////////////////////////////////////////////////////////////////
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(example);
            stringBuilder.Replace("dishwasher", "galaxy");


            Console.WriteLine(example);
            Console.WriteLine(stringBuilder.ToString());

            Console.ReadLine();
        }
    }
}
