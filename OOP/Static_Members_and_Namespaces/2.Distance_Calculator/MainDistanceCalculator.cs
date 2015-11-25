using System;
using _1.Point3D;

namespace _2.Distance_Calculator
{
    class MainDistanceCalculator
    {
        static void Main()
        {
            var pointA = new Point3D(12.1, 13.3, 12.5);
            var pointB = new Point3D(1.4, 3, 5.5);
            Console.WriteLine(DistanceCalculator.CalculateDistance(pointA, pointB));
        }
    }
}
