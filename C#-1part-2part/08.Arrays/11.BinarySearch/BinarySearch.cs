//14. Write a program that finds the index of given element in a sorted array of integers 
//by using the binary search algorithm (find it in Wikipedia).
//http://en.wikipedia.org/wiki/Binary_search_algorithm

using System;

class BinarySearch
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3, 4, 9, 0, 17, 13 };
        //Find index of element "9" in the sort array
        int element = 9;
        Array.Sort(intArray);

        int elementMin= 0;
        int elementMax = intArray.Length-1;
        int elementMiddle = 0;

        while (elementMax>=elementMin)
        {
            elementMiddle = (elementMin+elementMax)/2;
            {
                if (intArray[elementMiddle] < element)
                {
                    elementMin = elementMiddle + 1;
                }
                else if (intArray[elementMiddle] > element)
                {
                    elementMax = elementMiddle - 1;
                }
                else
                {
                    for (int i = 0; i < intArray.Length; i++)
                    { 
                        Console.Write(intArray[i]+" ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The index of given element is: {0}", elementMiddle);
                    break;
                }
            }
        }
        
    }
}