using Geometry.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public static class Equation
    {
        public static double GetHypotenuse(double rightAngle)
        {
            return Math.Sqrt(rightAngle * rightAngle + rightAngle * rightAngle);
        }
        public static double GetHypotenuse(double leg1, double leg2)
        {
            return Math.Sqrt(leg1 * leg1 + leg2 * leg2);
        }
        public static double GetTriangleThirdSideLength(double side, double side2, double angle)
        {
            return Math.Sqrt((side * side + side2 * side2) - 2 * side * side2 * Math.Cos(angle));
        }
        public static double GetThirdAngleTriangle(double angle1, double angle2)
        {
            return 180 - angle1 - angle2;
        }
    }
}
