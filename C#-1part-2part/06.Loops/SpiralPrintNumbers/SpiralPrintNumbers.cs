//Write a program that reads a positive integer number N (N < 20) from console 
//and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
using System;

    class SpiralPrintNumbers
    {
        static void Main()
        {
            Console.Write("Please enter positive integer number 0 < N <= 20: ");
            uint n = uint.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write(rows);
            }
        }
    }

