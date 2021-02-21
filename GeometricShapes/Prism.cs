using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Prism:IObject3D
    {
        double sideA,sideB,hight;
        
        public Prism(double a,double b,double h)
        {
            this.sideA = a;
            this.sideB = b;
            this.hight = h;
        }
        public double CalculateFullSurface()
        {
            double B = sideA * sideB;
            double P = sideA + sideB;
            return (2*B)+(P*hight);
        }
        public double CalculateVolume()
        {
            double B = sideA * sideB;
            return (B*hight);
        }
    }
}
