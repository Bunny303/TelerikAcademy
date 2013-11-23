//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

    class NFakKFakDivNMinusKFak
    {
        static void Main()
        {
            //Input N and K
            Console.Write("Please enter N (1<N<K): ");
            uint N = uint.Parse(Console.ReadLine());
            Console.Write("Please enter K (1<N<K): ");
            uint K = uint.Parse(Console.ReadLine());

            //Calculate... N!*K! / (K-N)! = N!*K(K-1)..(K-N+1)
            BigInteger result = 1;
            for (uint i = 1; i <= K; i++)
            {
                if (i <= N)
                {
                    result = result * i;
                }
                if (i >= (K-N+1))
                {
                    result = result * 1;
                }
            }
            Console.WriteLine("N!*K!/(K-N)! = {0}", result);
        }
    }

