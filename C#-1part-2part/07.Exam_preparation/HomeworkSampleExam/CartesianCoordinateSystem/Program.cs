using System;

    class Program
    {
        static void Main()
        {
            //Input data and reading from the console
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            //Check location of given point and print the results
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1");
            }

            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("2");
            }

            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("3");
            }

            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("4");
            }

            else if ((x == 0) && (y != 0))
            {
                Console.WriteLine("5");
            }

            else if ((x != 0) && (y == 0))
            {
                Console.WriteLine("6");
            }

            else 
            {
                Console.WriteLine("0");
            }
        }
    }
