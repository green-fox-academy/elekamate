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

        // Properties
        public decimal WaterAmount { get; set; }
        public decimal WaterNeedThreshold { get; set; }
        public string PlantColor { get; set; }

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

        // Constructures
        public Plant(string argPlantColor)
        {
            PlantColor = argPlantColor;
        }

        // Methods
        public void Watering(int argWateringAmount)
        {
            WaterAmount += argWateringAmount * WaterAbsorvationPercentage;
        }
    }
}
