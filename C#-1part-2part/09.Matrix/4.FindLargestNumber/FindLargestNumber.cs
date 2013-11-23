// 4. Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class FindLargestNumber
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}] = ",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());
        
        Array.Sort(array);

        int index = Array.BinarySearch(array, k);

        while (index < 0)
        {
            if (k < array[0])
            {
                break;
            }
            k--;
            index = Array.BinarySearch(array, k);

        }
        if (index < 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("The number is: {0}", array[index]);
        }
    }
}
