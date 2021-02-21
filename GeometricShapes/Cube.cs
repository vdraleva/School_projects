using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Cube : IObject3D
    {
        double sideA;

        public Cube(double a)
        {
            this.sideA = a;
        }
        public double CalculateFullSurface()
        {
            return 6 * (sideA * sideA);
        }
        public double CalculateVolume()
        {
            return (sideA * sideA * sideA);
        }
    }
}
