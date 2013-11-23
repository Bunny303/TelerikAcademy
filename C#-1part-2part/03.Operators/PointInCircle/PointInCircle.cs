using System;


namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Enter the x coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            int cirleRadius = 5;
            int d = (x * x) + (y * y);
            if (d <= cirleRadius * cirleRadius)
            {
                Console.WriteLine("The given coordinates are within the circle");
            }
            else
            {
                Console.WriteLine("The given coordinates are outside of the circle");
            }    
         }
    }
}
