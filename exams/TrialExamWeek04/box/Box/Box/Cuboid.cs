using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    // Create a class that represents a cuboid:
    // It should take its three dimensions as constructor parameters (numbers)
    // It should have a method called `GetSurface` that returns the cuboid's surface
    // It should have a method called `GetVolume` that returns the cuboid's volume
    class Cuboid
    {
        private double aSide { get; set; }
        private double bSide { get; set; }
        private double cSide { get; set; }

        public Cuboid(double argaSide, double argbSide, double argcSide)
        {
            this.aSide = argaSide;
            this.bSide = argbSide;
            this.cSide = argcSide;
        }

        public double GetVolume()
        {
            return aSide * bSide * cSide;
        }

        public double GetSurface()
        {
            return (aSide * bSide + bSide * cSide + aSide * cSide) * 2;
        }

    }
}