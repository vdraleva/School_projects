using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Point : GeometryObject
    {
        public double abcis;
        public double ordinata;

        public Point(double abcis, double ordinata)
        {
            this.abcis = abcis;
            this.ordinata = ordinata;
        }
    }
}
