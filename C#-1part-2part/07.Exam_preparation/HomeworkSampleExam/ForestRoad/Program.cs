using System;

    class Program
    {
        static void Main()
        {
            //Input
            uint n = uint.Parse(Console.ReadLine());

            //Output first part
            for (uint row = 1; row <= n; row++)
            {
                for (uint col = 1; col <= n; col++)
                {
                    if (row != col)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            //Output second part
            uint counter = 0;
            for (uint row = (n+1); row <= ((2 * n) - 1); row++)
            {
                counter = counter + 2;
                for (uint col = 1; col <= n; col++)
                {
                    if (row == (col + counter))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }

