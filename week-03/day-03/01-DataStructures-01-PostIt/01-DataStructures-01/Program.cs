using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01_DataStructures_01.StructPostIt;

namespace _01_DataStructures_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //an orange with blue text: "Idea 1"
            //a pink with black text: "Awesome"
            //a yellow with green text: "Superb!"

            //public string BackgroundColor;
            //public string Text;
            //public string TextColor;

            PostIt idea1 = new PostIt();
            idea1.BackgroundColor = "orange";
            idea1.TextColor = "blue";
            idea1.Text = "Idea1";

            PostIt Awesome = new PostIt();
            Awesome.BackgroundColor = "pink";
            Awesome.TextColor = "black";
            Awesome.Text = "Awesome";

            PostIt Superb = new PostIt();
            Superb.BackgroundColor = "yellow";
            Superb.TextColor = "green";
            Superb.Text = "Superb!";

            Console.ReadKey();
        }
    }


}
