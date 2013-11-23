//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//{4, 3, 1, 4, 2, 5, 8}, S=11 --> {4, 2, 5}
using System;

class SequenceWithGivenSum
{
    static void Main()
    {
        //Declare array and sym S;
        int[] intArray = { 4, 3, 1, 4, 2, 5, 8, 3 };
        Console.Write("Please enter S: ");
        int S = int.Parse(Console.ReadLine());

        int sum = 0;
                
        //Print array
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.Write(", S={0} --> ", S);

        //First loop show start element, second loop make sum of elements from left to right
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = i; j < intArray.Length; j++)
            {
                sum = sum + intArray[j];
                if (sum == S)
                {
                    //Print sequence 
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(intArray[k] + " ");
                    }
                    Console.Write("; ");
                }
            }
            sum = 0;
        }
    }
}
