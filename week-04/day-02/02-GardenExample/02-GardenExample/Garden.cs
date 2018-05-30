using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Garden
    {
        // Properties
        public static List<Plant> Plants { get; set; }

        // Constructors
        public Garden()
        {
            Plants = new List<Plant>();
        }

        // Methods
        public void ShowTheGarden()
        {
            int treeCounter=0;
            int flowerCounter=0;

            foreach (Plant xPlant in Plants)
            {
                flowerCounter = (xPlant is Flower) ? flowerCounter + 1 : flowerCounter;
                treeCounter = (xPlant is Tree) ? treeCounter + 1 : treeCounter;
            }

            Console.WriteLine($"Number of trees: {treeCounter} /n Number of flowers: {flowerCounter}");
        }

        public void Watering(double argWateringAmount)
        {
            int numberOfPlantsToWater = 0;
            double wateringAmountPerPlant = 0;
            List<Plant> plantsToWater = new List<Plant>();

            foreach (Plant xPlant in Plants)
            {
                if (xPlant.WaterNeedThreshold>xPlant.WaterAmount)
                {
                    numberOfPlantsToWater++;
                }
            }

            wateringAmountPerPlant = argWateringAmount / numberOfPlantsToWater;

            foreach (Plant xPlant in plantsToWater)
            {
                xPlant.Watering(wateringAmountPerPlant);
            }

        }

    }
}
