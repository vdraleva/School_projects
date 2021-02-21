using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Circle : IObject2D
    {
        double radious;

        public Circle(double r)
        {
            this.radious = r;
        }
        public double CalculateArea()
        {
            return (Math.PI * radious * radious);
        }

        public double CalculatePerimeter()
        {
            return (Math.PI * 2 * radious);

        }
    }
}
