using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Cylinder : IObject3D
    {

        double hight, radious;

        public Cylinder(double h, double r)
        {
            this.hight = h;
            this.radious = r;
        }
        public double CalculateFullSurface()
        {
            return (2 * Math.PI * radious * radious) + (2 * Math.PI * radious * hight);
        }       
        public double CalculateVolume()
        {
            return (Math.PI * radious * radious * hight);
        }
    }
    internal interface IObject3D
    {
    }

}
