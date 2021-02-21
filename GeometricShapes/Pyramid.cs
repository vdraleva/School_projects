using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Pyramid:IObject3D
    {
        double sideA, hight,hightToSide;

        public Pyramid(double a, double h,double s)
        {
            this.sideA = a;
            this.hight = h;
            this.hightToSide = s;
        }
        public double CalculateFullSurface()
        {
            return (2*sideA*hightToSide)+(sideA*sideA);

        }
        public double CalculateVolume()
        {
            return (sideA*sideA * hight)/3;
        }
    }
}

