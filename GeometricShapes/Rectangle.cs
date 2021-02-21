using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Rectangle : IObject2D
    {
        double sideA, sideB;

        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;

        }
        public double CalculateArea()
        {
            double S = sideA * sideB;
            return S;
        }

        public double CalculatePerimeter()
        {
            return (2 * sideA + 2 * sideB);
        }
    }

    internal interface IObject2D
    {
    }
}
