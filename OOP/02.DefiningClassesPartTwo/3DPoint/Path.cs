using System;
using System.Collections.Generic;

namespace _3DPoint
{
    // 4. Define class
    public class Path
    {
        public List<Point3D> points = new List<Point3D>();

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
        }

        public void AddPoint(Point3D point)
        {
            Points.Add(point);
        }
    }
}
