using System;

    class InCircleOutRectangle
    {
        static void Main()
        {
            Console.Write("Enter the x coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 9)
            {
                if ((y > 1) || (y < -1))
                {
                    Console.WriteLine("The given coordinates are outside of the rectangle");
                }
                else
                {
                    if ((y < 1 || y > -1) && x < -1)
                    {
                        Console.WriteLine("The given coordinates are outside of the rectangle");
                    }
                    else
                    {
                        Console.WriteLine("The given coordinates are within the circle and within the rectangle");
                    }
                }
            }
            else Console.WriteLine("The given coordinates are outside of the circle");
        }
    }

