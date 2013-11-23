//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

    class NFakDivKFak
    {
        static void Main()
        {
            //Input N and K
            Console.Write("Please enter K (1<K<N): ");
            uint K = uint.Parse(Console.ReadLine());
            Console.Write("Please enter N (1<K<N): ");
            uint N = uint.Parse(Console.ReadLine());

            //Calculate... N!/K! = (K+1)..N
            BigInteger result = 1;
            for (ulong i = (K + 1); i <= N; i++)
            {
                result = result * i;
            }
            Console.WriteLine("N!/K! = {0}", result);
        }
    }

