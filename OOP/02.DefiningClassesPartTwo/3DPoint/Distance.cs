using System;

namespace _3DPoint
{
    // 3. Define class
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0d;
            distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
            return distance;
        }
    }
}
