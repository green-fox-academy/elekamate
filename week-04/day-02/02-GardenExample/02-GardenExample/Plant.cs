using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Plant
    {
        // Fields
        private decimal waterAbsorvationPercentage;

        public int WaterAmount { get; set; }
        public int WaterNeedThreshold { get; set; }


        public decimal WaterAbsorvationPercentage
        {
            get
            {
                return waterAbsorvationPercentage;
            }
            set
            {
                waterAbsorvationPercentage = (value>=0 || value <=1) ? value : 0;
            }

        }



    }
}
