using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Cone:IObject3D
    {
        double radious, hight;

        public Cone(double r, double h)
        {
            this.radious = r;
            this.hight = h;
        }
        public double CalculateFullSurface()
        {
            return (Math.PI*radious*2)+(Math.PI*radious*hight);
        }
        public double CalculateVolume()
        {
            return (Math.PI*radious*2*hight)/3;
        }
    }
}
