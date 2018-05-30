using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Flower : Plant
    {
        public Flower(string PlantColor) : base (PlantColor)
        {
            WaterAbsorvationPercentage = 0.75m;
            WaterNeedThreshold = 5;
            Garden.Plants.Add(this);
        }

    }
}
