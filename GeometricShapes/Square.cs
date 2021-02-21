using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Square : IObject2D
    {
        double sideA;

        public Square(double a)
        {
            this.sideA = a;
        }
        public double CalculateArea()
        {          
            return sideA * sideA;
        }

        public double CalculatePerimeter()
        {
            return (sideA+sideA+sideA+sideA);
        }
    }
}
