using System;
using System.Collections.Generic;
using System.IO;

namespace _3DPoint
{
    // 4. Define static class
    public static class PathStorage
    {
        // Method for saving paths from a text file
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../SavePaths.txt"))
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine(point);
                }
            }
        }

        // Method for loading paths from a text file
        public static List<Path> LoadPath()
        {
            Path loadPath = new Path();
            List<Path> allLoadedPathes = new List<Path>();
            using (StreamReader reader = new StreamReader(@"../../LoadPaths.txt"))
            {
                for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    Point3D point = new Point3D();
                    string[] points = line.Split(',');
                    point.X = int.Parse(points[0]);
                    point.Y = int.Parse(points[1]);
                    point.Z = int.Parse(points[2]);
                    loadPath.AddPoint(point);
                }
                allLoadedPathes.Add(loadPath);
                loadPath = new Path();
            }
            return allLoadedPathes;
        }
    }
}
