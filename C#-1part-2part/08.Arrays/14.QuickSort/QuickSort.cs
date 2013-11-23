//14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
//http://en.wikipedia.org/wiki/Quick_sort
// Отвратителна задача!

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        //Declare array
        string[] stringArray = { "ba", "rk", "padt", "mooo", "dada", "aghkwht" };

        //Print the unsorted array   
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine();

        // Call method to sort the array
        Quicksort(stringArray, 0, stringArray.Length - 1);

        // Print the sorted array
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Quicksort(string[] stringArray, int left, int right)
    {
        int i = left;
        int j = right;

        //Pick pivot
        string pivot = stringArray[left + (right - left) / 2];

        while (i <= j)
        {
            while (stringArray[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (stringArray[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap the elements
                string tmp = stringArray[i];
                stringArray[i] = stringArray[j];
                stringArray[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(stringArray, left, j);
        }

        if (i < right)
        {
            Quicksort(stringArray, i, right);
        }
        
    }
}
