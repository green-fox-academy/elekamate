using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            Console.Write("Gimme the size of the chess table: ");
            int n_Chesstable = Convert.ToInt32(Console.ReadLine());
            string out_String = "";

            for (int i = 1; i < n_Chesstable + 1; i++)
            {
                if (i % 2 == 1)
                {
                    out_String = "%";
                }
                else
                {
                    out_String = " ";
                }

                for (int j = 2; j < n_Chesstable + 1; j++)
                {
                    if (out_String.Substring(out_String.Length-1) == "%")
                    {
                        out_String += " ";
                    }
                    else
                    {
                        out_String += "%";
                    }
                }
                Console.WriteLine(out_String);
            }

            Console.ReadLine();
        }
    }
}
