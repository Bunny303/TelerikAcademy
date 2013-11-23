using System;
using System.Collections.Generic;
using System.Text;

namespace _3DPoint
{
    class Program
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(5, 8, -4);
            Point3D secondPoint = new Point3D(1, 1, 3);
            
            //Test method ToString and method CalculateDistance
            Console.WriteLine("Distance between {0} and {1} is: {2:0.00}", firstPoint, secondPoint, Distance.CalculateDistance(firstPoint, secondPoint));

            //Test (0,0,0)
            Console.WriteLine(Point3D.ZeroPoint);
            Console.WriteLine();

            //Test method SavePath
            Path testPath = new Path();
            testPath.AddPoint(firstPoint);
            testPath.AddPoint(secondPoint);
            PathStorage.SavePath(testPath);

            //Test method LoadPath and print result 
            List<Path> testList = PathStorage.LoadPath();
            foreach (var path in testList)
            {
                foreach (var point in path.Points)
                {
                    Console.WriteLine(point);
                }
            }
        }
    }
}
