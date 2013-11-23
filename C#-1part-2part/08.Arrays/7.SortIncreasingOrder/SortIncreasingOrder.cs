//7. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;

class SortIncreasingOrder
{
    static void Main()
    {
        //Declare array
        int[] intArray = { 5, 6, 4, 7, 9, 7 };
        
        int minElement = 0;
        int tempElement = 0;
        
        //Compare first element with next elements, second element with next elements, etc.
        for (int i = 0; i < (intArray.Length-1); i++)
        {
            minElement = i;
            for (int j = i + 1; j < intArray.Length; j++)
            {
                if (intArray[j] < intArray[minElement])
                {
                    minElement = j;
                }
            }
            //If minimum element is not on right position 
            if (minElement != i)
            {
                tempElement = intArray[minElement];
                intArray[minElement] = intArray[i];
                intArray[i] = tempElement;
            }
        }
        //Print sort array
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i]+" ");
        }
        
    }
}