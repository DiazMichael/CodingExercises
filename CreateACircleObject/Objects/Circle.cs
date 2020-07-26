using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{/// <summary>
/// Circle object that contains info of the radius, circunference, area and soon position.
/// </summary>
    public class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }
        public double Area { get; set; }
        public double Circunference { get; set; }

        public Circle()
        {
            Console.WriteLine("A circle has been created");
        }
        public Circle(double radius) : this()
        {
            this.Radius = radius;
            this.Diameter = 2 * radius;
            this.Area = Math.Pow(radius, 2) * Math.PI;
            this.Circunference = Math.PI * 2 * radius;
            Console.WriteLine($"and its Radius is {this.Radius}");
        }
    }
}
