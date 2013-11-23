// 9. Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;

class MaximalElementAndSortArray
{
    static void Main()
    {
        int[] intArray = { 2, 4, 5, 8, 7, 1, 3 };

        Console.WriteLine("Max element: {0}", intArray[ReturnMaximalElement(intArray, 3)]);

        SortArrayDescending(intArray);
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i]+" ");
        }
    }

    static int ReturnMaximalElement(int[] intArray, int startIndex)
    {
        int maxElement = startIndex;

        for (int i = startIndex+1; i < intArray.Length; i++)
        {
            if (intArray[i] > intArray[maxElement])
            {
                maxElement = i;
            }
        }
        return maxElement;
    }

    static void SortArrayDescending(int[] intArray)
    {
        int tempElement = 0;
        
        for (int i = 0; i < intArray.Length-1; i++)
        {
            int maxElement = ReturnMaximalElement(intArray, i);
            if (maxElement != i)
            {
                tempElement = intArray[maxElement];
                intArray[maxElement] = intArray[i];
                intArray[i] = tempElement;
            }
        }
    }
}
