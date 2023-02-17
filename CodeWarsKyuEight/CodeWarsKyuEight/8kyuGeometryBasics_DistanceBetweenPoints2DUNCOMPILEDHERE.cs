using System;
using System.Drawing;

namespace CodeWarsKyuEight
{
    public class DistantedPoints
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            double x = a.X - b.X;
            double y = a.Y - b.Y;
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
}
//twierdzenie pitagorasa :)


/*
 This series of katas will introduce you to basics of doing geometry with computers.

Point objects have fields X and Y.

Write a function calculating distance between Point a and Point b.

Tests compare expected result and actual answer with tolerance of 1e-6.
*/