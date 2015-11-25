

namespace _2.Distance_Calculator
{
    using System;
    using _1.Point3D;

    public static class DistanceCalculator
    {
        private const double dev = 2;
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            return Math.Sqrt(Math.Pow(pointB.CoordX - pointA.CoordX, dev) + Math.Pow(pointB.CoordY - pointA.CoordY, dev) + Math.Pow(pointB.CoordZ - pointA.CoordZ, dev));
        }
    }
}
