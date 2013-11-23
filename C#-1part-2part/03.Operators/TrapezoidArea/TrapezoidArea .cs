using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Write side a of the trapezoid:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Write side b of the trapezoid:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Write height h of the trapezoid:");
            int h = int.Parse(Console.ReadLine());
            double Area = ((a + b)*h) / 2d;
            Console.WriteLine("The trapezoid's area is:{0}", Area);
        }
    }

