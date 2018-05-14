using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            //
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.Write("Number of girlz at the party: ");
            int party_NumberOfGirls = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of boiz at the party: ");
            int party_NumberOfBoys = Convert.ToInt32(Console.ReadLine());

            int party_NumberOfPpl = party_NumberOfGirls + party_NumberOfBoys;


            if (party_NumberOfGirls == 0)
            {
                Console.WriteLine("Sausage party!");
            }
            else if (party_NumberOfBoys != party_NumberOfGirls && party_NumberOfPpl > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (party_NumberOfPpl < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (party_NumberOfBoys == party_NumberOfGirls && party_NumberOfPpl > 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            else
            {
                Console.WriteLine("I have nothing to say.");
            }

            Console.ReadLine();
        }
    }
}
