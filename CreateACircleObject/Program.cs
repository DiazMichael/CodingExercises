using Geometry.Objects;
using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var firstCircle = new Circle(4.44);

                Console.WriteLine(firstCircle.Area);
                Console.WriteLine(firstCircle.Circunference);
                Console.WriteLine(firstCircle.Diameter);
                var firstRectangle = new Rectangle(4);

                Console.WriteLine($"{firstRectangle.Area} : Area");
                Console.WriteLine($"{firstRectangle.Side} : Side");
                Console.WriteLine($"{firstRectangle.Diagonal} : Diagonal");
                Console.WriteLine($"{firstRectangle.Perimeter} : Perimeter");

                var firstTriangle = new Triangle();
                var secondTriangle = new Triangle(10);
                var thirdTriangle = new Triangle(10, 10, 30);
                Console.WriteLine($"{firstTriangle.AngleAB} : Empty Triangle");
                Console.WriteLine($"{firstTriangle.AngleBC} : Empty Triangle");
                Console.WriteLine($"{firstTriangle.AngleCA} : Empty Triangle");
                Console.WriteLine($"{firstTriangle.Area} : Empty Triangle");
                Console.WriteLine($"{firstTriangle.Hypotenuse} : Empty Triangle");
                Console.WriteLine($"{firstTriangle.Perimeter} : Empty Triangle");
                Console.WriteLine($"{secondTriangle.SideA} SideA : Second Triangle");
                Console.WriteLine($"{secondTriangle.SideB} SideB : Second Triangle");
                Console.WriteLine($"{secondTriangle.SideC} SideC : Second Triangle");
                Console.WriteLine($"{secondTriangle.AngleAB} AngleAB : Second Triangle");
                Console.WriteLine($"{secondTriangle.AngleBC} AngleBC : Second Triangle");
                Console.WriteLine($"{secondTriangle.AngleCA} AngleCA : Second Triangle");
                Console.WriteLine($"{secondTriangle.Perimeter} Perimeter : Second Triangle");
                Console.WriteLine($"{thirdTriangle.SideA} SideA : Third Triangle");
                Console.WriteLine($"{thirdTriangle.SideB} SideB : Third Triangle");
                Console.WriteLine($"{thirdTriangle.SideC} SideC : Third Triangle");
                Console.WriteLine($"{thirdTriangle.AngleAB} AngleAB : Third Triangle");
                Console.WriteLine($"{thirdTriangle.AngleBC} AngleBC : Third Triangle");
                Console.WriteLine($"{thirdTriangle.AngleCA} AngleCA : Third Triangle");
                Console.WriteLine($"{thirdTriangle.Perimeter} Perimeter : Third Triangle");


            }

            }
        }
}
