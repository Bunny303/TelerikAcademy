// 15. * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

class OperationsWithNumbers
{
    static void Main()
    {
        Console.WriteLine(ReturnMinimum(7.3, 8.4, 4.56));
        Console.WriteLine(ReturnMaximum(7, 8, 4));
        Console.WriteLine(ReturnSum(1, 2, 3));
        Console.WriteLine(ReturnAverage(2, 3, 4, 5));
        Console.WriteLine(ReturnProduct(2, 3, 4, 5));
    }

    static T ReturnMinimum<T>(params T[] array) 
    {
        dynamic minElement = array[0];
        foreach (var element in array)
        {
            if (element < minElement)
            {
                minElement = element;
            }
        }
        return minElement;
    }

    static T ReturnMaximum<T>(params T[] array)
    {
        dynamic maxElement = array[0];
        foreach (var element in array)
        {
            if (element > maxElement)
            {
                maxElement = element;
            }
        }
        return maxElement;
    }

    static T ReturnSum<T>(params T[] array)
    {
        dynamic sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum;
    }

    static double ReturnAverage<T>(params T[] array)
    {
        dynamic sum = 0;
        dynamic counter = 0;
        double average = 0;
        foreach (var element in array)
        {
            sum += element;
            counter++;
        }
        return average = (double)sum / counter;
    }

    static T ReturnProduct<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (var element in array)
        {
            product *= element;
        }
        return product;
    }
}
