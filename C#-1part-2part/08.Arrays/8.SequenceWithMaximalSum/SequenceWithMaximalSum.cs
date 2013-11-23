//Write a program that finds the sequence of maximal sum in given array.
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
using System;

class SequenceWithMaximalSum
{
    static void Main()
    {
        //Declare array
        int[] intArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int end = intArray[0]; 
        int maxEnd = intArray[0];
        int maxLen = 1; 
        int len = 1;
        int startIndex = 0;
        int index = 0;

        //Kadane's algorithm (http://en.wikipedia.org/wiki/Maximum_subarray_problem)
        for (int i = 1; i < intArray.Length; ++i)
        {
            if (intArray[i] + maxEnd > intArray[i])
            {
                maxEnd = intArray[i] + maxEnd;
                len++;
            }
            else
            {
                maxEnd = intArray[i];
                index = i;
                len = 1;
            }

            if (maxEnd > end)
            {
                end = maxEnd;
                maxLen = len;
                startIndex=index;
            }
        }

        //Print results
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.Write(" }--> { ");
        for (int i = startIndex; i < startIndex + maxLen; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.WriteLine("}");
    }
}
