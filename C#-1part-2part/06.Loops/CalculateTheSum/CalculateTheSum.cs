//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

    class CalculateTheSum
    {
        static void Main()
        {
            //Input N and X
            Console.Write("Please enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please enter X: ");
            int X= int.Parse(Console.ReadLine());

            //Input N!, X^N and sum
            decimal nFakturiel = 1.0M;
            decimal xPower = 1.0M;
            decimal sum = 1.0M;

            //Calculate the sum
            for (int i = 1; i <= N; i++)
            {
                nFakturiel = nFakturiel * i;
                xPower = xPower * X;
                sum = sum + (nFakturiel / xPower);
            }
            Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N = {0}", sum);
                
        }
    }
