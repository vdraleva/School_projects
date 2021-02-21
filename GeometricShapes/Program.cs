using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_Figuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Квадрат със страна 11см");
            Square square1 = new Square(11);
            Console.Write("Има периметър равен на: ");
            Console.Write(square1.CalculatePerimeter());
            Console.Write(" и лице равно на: ");
            Console.Write(square1.CalculateArea());
            Console.WriteLine();

            Console.WriteLine("Правоъгълник със страни 4см и 2 см");
            Rectangle rectangle1 = new Rectangle(4, 2);
            Console.Write("има периметър равен на: ");
            Console.Write(rectangle1.CalculatePerimeter());
            Console.Write(" и лице равно на: ");
            Console.Write(rectangle1.CalculateArea());
            Console.WriteLine();

            Console.WriteLine("Триъгълник със страни 3см, 4см и 5см");
            Triangle triangle1 = new Triangle(3,4,5);
            Console.Write("Има периметър равен на: ");
            Console.Write(triangle1.CalculatePerimeter());
            Console.Write(" и лица равно на: ");
            Console.Write(triangle1.CalculateArea());
            Console.WriteLine();

            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.CalculatePerimeter());
            Console.WriteLine(circle1.CalculateArea());

            Cube cube1 = new Cube(6);
            Console.WriteLine(cube1.CalculateFullSurface());
            Console.WriteLine(cube1.CalculateVolume());

            Cylinder cylinder1 = new Cylinder(8,4);
            Console.WriteLine(cylinder1.CalculateFullSurface());
            Console.WriteLine(cylinder1.CalculateVolume());

            Prism prism1 = new Prism(8,12,3);
            Console.WriteLine(prism1.CalculateFullSurface());
            Console.WriteLine(prism1.CalculateVolume());

            Pyramid pyramid1 = new Pyramid(20,13,16);
            Console.WriteLine(prism1.CalculateFullSurface());
            Console.WriteLine(prism1.CalculateVolume());
        }
    }
}
