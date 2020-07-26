using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Objects
{
    public class PointInSpace
    {
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public double[] Vector { get; set; } = new double[] { 0, 0 };

        public PointInSpace()
        {
            Console.WriteLine("A point in space has been created at [0, 0]");

        }
        public PointInSpace(double x, double y)
        {
            this.XPosition = x;
            this.YPosition = y;
            this.Vector = new double[] { x, y };
        }
    }
}
