// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;

class OperationsWithSetsOfIntegers
{
    static void Main()
    {
        Console.WriteLine(ReturnMinimum(2, 3, 5));
        Console.WriteLine(ReturnMaximum(7, 8, 4));
        Console.WriteLine(ReturnAverage(2, 3, 4, 5));
        Console.WriteLine(ReturnSum(1, 2, 3));
        Console.WriteLine(ReturnProduct(2, 3, 4, 5));
    }

    static int ReturnMinimum(params int[] setIntegers)
    {
        int minElement = int.MaxValue;
        foreach (int element in setIntegers)
        {
            if (element < minElement)
            {
                minElement = element;
            }
        }
        return minElement;
    }

    static int ReturnMaximum(params int[] setIntegers)
    {
        int maxElement = int.MinValue;
        foreach (int element in setIntegers)
        {
            if (element > maxElement)
            {
                maxElement = element;
            }
        }
        return maxElement;
    }

    static int ReturnSum(params int[] setIntegers)
    {
        int sum = 0;
        foreach (int element in setIntegers)
        {
            sum += element;
        }
        return sum;
    }

    static double ReturnAverage(params int[] setIntegers)
    {
        int sum = 0;
        double counter = 0.0d;
        double average = 0.0d;
        foreach (int element in setIntegers)
        {
            sum += element;
            counter++;
        }
        return average = sum / counter;
    }

    static int ReturnProduct(params int[] setIntegers)
    {
        int product = 1;
        foreach (int element in setIntegers)
        {
            product *= element;
        }
        return product;
    }

    
}
