//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Cn= (2n)!/(n+1)!n!, n>=0
//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Please enter positive integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            
            BigInteger denominator = 1; 
            BigInteger numerator = 1;
            
            //Cn= (2n)!/(n+1)!n! = (n+2)..(2n)/n!
            for (uint i = n+2; i <= 2*n; i++)
            {
                numerator = numerator * i;
            }

            for (uint i = 1; i <= n; i++)
            {
                denominator = denominator * i;
            }

            Console.WriteLine("Cn= (2n)!/(n+1)!n! = {0}", numerator / denominator);
        }
    }

