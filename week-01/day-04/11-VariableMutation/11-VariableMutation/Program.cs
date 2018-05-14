using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            a += 10;

            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;

            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;

            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;

            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e *= e;

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool f_BiggerOrNot;

            if (f1>f2)
            {
                f_BiggerOrNot = true;
            }
            else
            {
                f_BiggerOrNot = false;
            }
            

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool g_BiggerOrNot;

            if (g2*g2>g1)
            {
                g_BiggerOrNot = true;
            }
            else
            {
                g_BiggerOrNot = false;
            }

            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)
            bool h_DivisiorOrNot;
            long h_Mod= h % 11;

            if (h_Mod==0)
            {
                h_DivisiorOrNot = true;
            }
            else
            {
                h_DivisiorOrNot = false;
            }

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            double i2_Squared = Math.Pow((double) i2, (double) 2);
            double i2_Root = Math.Pow(i2,(double) 1/ 2);
            bool i_BoolComparison;

            if (i1> i2_Squared && i1< i2_Root)
            {
                i_BoolComparison = true;
            }
            else
            {
                i_BoolComparison = false;
            }

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            bool j_Dividable;

            if (j % 3 ==0 || j % 5==0)
            {
                j_Dividable = true;
            }
            else
            {
                j_Dividable = false;
            }

            string k = "Apple";
            string k_output=k;
            //fill the k variable with its cotnent 4 times
            for (int i = 1; i !=4; i++)
            {
                k_output += k;
            }

            Console.WriteLine(k);
        }
    }
}
