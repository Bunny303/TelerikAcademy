using System;

    class PerimeterAndAreaOfCircle
    {
        static void Main()
        {
            Console.Write("Please enter radius r of a circle: ");
            string radius = Console.ReadLine();
            int r = int.Parse(radius);

            double perimeter = (double)(2 * Math.PI*r);
            double area = (double)(Math.PI * r * r);

            Console.WriteLine("The parimeter is {0:0.00} and the area is {1:0.00}", perimeter, area);
        }
    }

