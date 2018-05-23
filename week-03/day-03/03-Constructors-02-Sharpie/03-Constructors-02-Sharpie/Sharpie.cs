using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_02_Sharpie
{
    class Sharpie
    {
        //Create Sharpie class
        //    We should know about each sharpie their Color(which should be a string),
        //        Width(which will be a floating point number), InkAmount(another floating point number)
        //    When creating one, we need to specify the Color and the Width
        //    Every sharpie is created with a default 100 as InkAmount
        //    We can Use() the sharpie objects
        //        which decreases inkAmount
        private string color;
        private double width;
        private double inkAmount;

        public Sharpie(string color, double width, double inkAmount = 100)
        {
            this.inkAmount=inkAmount;
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkAmount--;
        }
    }
}
