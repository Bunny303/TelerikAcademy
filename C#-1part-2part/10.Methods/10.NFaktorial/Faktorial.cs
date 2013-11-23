//10. Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Numerics;

class Faktorial
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, CalculateNFaktorial(i));
        }
    }

    static BigInteger CalculateNFaktorial(int n)
    {
        int[] intArray = new int[n];
        BigInteger nFaktorial = 1;

        for (int i=0; i<intArray.Length; i++)
        {
            intArray[i] = i + 1;
            nFaktorial = nFaktorial * intArray[i];
        }
        return nFaktorial;
    }
}
