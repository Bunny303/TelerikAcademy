//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix

using System;

    class PrintNumberMatrix
    {
        static void Main()
        {
            Console.Write("Please enter positive integer number 0 < N <= 20: ");
            uint n = uint.Parse(Console.ReadLine());

            

            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = rows; col < rows + n; col++)
                {
                    Console.Write("{0,2} ", col);
                }

                Console.WriteLine();
            }
        }
    }

