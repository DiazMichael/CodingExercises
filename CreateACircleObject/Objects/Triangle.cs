using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Objects
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public PointInSpace Vortex1 { get; set; }
        public PointInSpace Vortex2 { get; set; }
        public PointInSpace Vortex3 { get; set; }
        public double AngleAB { get; set; }
        public double AngleBC { get; set; }
        public double AngleCA { get; set; }

        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Hypotenuse { get; set; }
        public TriangleBySideType Type { get; set; }

        public Triangle()
        {
            Console.WriteLine("A Triangle has been created");
        }
        public Triangle(double side) : this()
        {
            Console.WriteLine($"It is an equilateral triangle of {side} side)");
            this.SideA = side;
            this.SideB = side;
            this.SideC = side;
            this.Perimeter = side * 3;
            this.AngleAB = 180 / 3;
            this.AngleBC = 180 / 3;
            this.AngleCA = 180 / 3;
            this.Type = TriangleBySideType.Equilateral;




        }
        public Triangle(double side, double side2, double angle) : this(side)
        {
            this.SideA = side;
            this.SideB = side2;
            this.SideC = Equation.GetTriangleThirdSideLength(side, side2, angle);
            this.AngleAB = angle;
            if (side == side2)
            {
                this.AngleBC = Equation.GetThirdAngleTriangle(AngleAB, AngleCA);
                this.AngleCA = Equation.GetThirdAngleTriangle(AngleAB, AngleBC);
            }
            this.Perimeter = side + side2 + this.SideC;


            


            
        }
    }
    public enum TriangleBySideType
    {
        Equilateral,
        Isosceles,
        Scalene,


    }
}
