using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLib
{
    public class ExtraMath
    {
        public static bool SolveQuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;
            double d = b*b - (4 * a * c);
            if(d < 0)
            {
                return false;
            }
            x1 = (-b-Math.Sqrt(d))/(2*a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            return true;
        }

        public static double GenerateRandomDouble(Random random, int min, int max)
        {
            return Math.Round(random.NextDouble() * (max - min) + min, 2);
        }
    }
}
