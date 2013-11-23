//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Collections;

class MaxSumOfElements
{
    static void Main()
    {
        //Input
        Console.WriteLine("Please enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter K: ");
        int K = int.Parse(Console.ReadLine());
        int[] intArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element [{0}]: ", i);
            intArray[i] = int.Parse(Console.ReadLine());
        }

        //Sort array 
        Array.Sort(intArray);

        //Print the last K elements /max K elements/
        Console.Write("K elements that have maximum sum are: ");
        for (int i = N-K; i < N; i++)
        {
            Console.Write(intArray[i]+" ");
        }
    }
}
