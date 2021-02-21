using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Triangle: IObject2D
    {
        double sideA, sideB, sideC;

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                this.sideA = a;
                this.sideB = b;
                this.sideC = c;
            }
            else
            {
                Console.WriteLine("No triangle");
            }
        }
        public double CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            double S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return S;
        }

        public double CalculatePerimeter()
        {
            return (sideA + sideB + sideC);

        }
    }
}
