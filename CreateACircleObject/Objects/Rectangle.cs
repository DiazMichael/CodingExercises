using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Rectangle
    {

        public double Side { get; set; }
        public double Diagonal { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public Rectangle()
        {
            Console.WriteLine("A Rectangle has been created");
        }

        public Rectangle(double side) : this()
        {
            this.Side = side;
            this.Area = side * side;
            this.Perimeter = 4 * side;
            this.Diagonal = Equation.GetHypotenuse(side);
        }

    }
}
