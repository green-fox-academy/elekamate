using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GardenExample
{
    class Tree : Plant
    {
        // Constructors
        public Tree()
        {
            WaterAbsorvationPercentage = 0.40m;
            Garden.Trees.Add(this);
        }

        
    }
}
