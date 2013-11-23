//4. Write methods that calculate the surface of a triangle by given:
//a) Side and an altitude to it; 
//b) Three sides; 
//c) Two sides and an angle between them. Use System.Math.

using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double h = 2.4;
        double angle = 90;
        Console.WriteLine(CalcSurfaceBySideAndAltitude(c, h));
        Console.WriteLine(CalcSurfaceByThreeSides(a, b, c));
        Console.WriteLine(CalcSurfaceByTwoSidesAndAngle(a, b, angle));
    }
    // a)
    static double CalcSurfaceBySideAndAltitude (double a, double h)
    {
        double surface = 0;
        return surface = (a * h) / 2;
    }

    // b)
    static double CalcSurfaceByThreeSides(double a, double b, double c)
    {
        double surface = 0;
        double s = (a+b+c)/2;
        return surface = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
    }

    // c)
    static double CalcSurfaceByTwoSidesAndAngle(double a, double b, double angle)
    {
        double surface = 0;
        return surface = (a * b * Math.Sin((angle * 0.0174533))) / 2;
    }
}