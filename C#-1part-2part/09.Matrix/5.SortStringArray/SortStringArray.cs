// 5. You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;

class SortStringArray
{
    static void Main()
    {
        Console.Write("Enter number of array elements: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = Console.ReadLine();
        }
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine();
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j]);
            }
            Console.WriteLine();
        }
    }
}
