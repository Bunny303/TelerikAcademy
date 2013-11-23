//13. * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
//http://en.wikipedia.org/wiki/Merge_sort
// http://kdikov.overbet.net/2013/01/csharp-arrays-merge-sort/ - source

using System;

class MergeSort
{
    static void Main()
    {
        int[] intArray = { 2, 5, 3, 8, 6, 15, 0, 13, 7, 29, 14, 4 };
        int[] tempArray = new int[intArray.Length];

        int intArraySize = intArray.Length;
        int currentLength = 1; //number of cells to compare
        int currentPosition = 0;
        int leftIndex = 0; //position of comparing element from left part
        int rightIndex = 0; //position of comparing element from right part
        while (currentLength <= intArraySize)
        {
            for (int i = 0; i < intArraySize; i = i + currentLength * 2)
            {
                while (currentPosition < intArraySize)
                {
                    //check if there are left elements
                    if (leftIndex < currentLength && rightIndex < currentLength && i + rightIndex + currentLength < intArraySize)
                    {
                        if (intArray[i + leftIndex] <= intArray[i + rightIndex + currentLength])
                        {
                            tempArray[currentPosition] = intArray[i + leftIndex];
                            leftIndex++;
                        }
                        else
                        {
                            tempArray[currentPosition] = intArray[i + rightIndex + currentLength];
                            rightIndex++;
                        }
                    }
                    else if (leftIndex < currentLength)
                    {
                        tempArray[currentPosition] = intArray[i + leftIndex];
                        leftIndex++;
                    }
                    else if (rightIndex < currentLength)
                    {
                        tempArray[currentPosition] = intArray[i + rightIndex + currentLength];
                        rightIndex++;
                    }
                    else
                    {
                        break;
                    }
                    currentPosition++;
                }
                rightIndex = 0;
                leftIndex = 0;
            }
            currentLength = currentLength * 2;
            currentPosition = 0;
            for (int i = 0; i < intArraySize; i++)
            {
                intArray[i] = tempArray[i];
            }
        }

        for (int i = 0; i < intArraySize; i++)
        {
            Console.WriteLine(intArray[i]);
        }

    }
}
