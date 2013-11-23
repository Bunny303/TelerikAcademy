//Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        //Input lenght of arrays
        Console.Write("Please enter array's length: ");
        int n = int.Parse(Console.ReadLine());

        //Declare arrays
        int[] firstArray = new int [n];
        int[] secondArray = new int[n];

        //Read arrays
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("First Array [{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("Second Array [{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //Compare arrays
        bool isEqual = true;
        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
                break;
            }
        }
        Console.WriteLine(isEqual);
    }
}

