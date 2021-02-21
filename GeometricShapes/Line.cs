using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Line : GeometryObject
    {
        public double endPoint;
        public double startPoint;

        public Line(double startPoint,double endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
    }
}
