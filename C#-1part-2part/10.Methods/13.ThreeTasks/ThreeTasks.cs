// 13. Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;

class ThreeTasks
{
    static void Main()
    {
        Console.WriteLine("\"1\" to reverse the digit of a number");
        Console.WriteLine("\"2\" to calculate the average of a sequence of integers");
        Console.WriteLine("\"3\" to solve a linear equation a * x + b = 0");
        Console.Write("Please enter the number of your choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    //First task
                    Console.Write("Please enter a positive number: ");
                    int number = int.Parse(Console.ReadLine());
                    try
                    {
                        Console.WriteLine(ReverseNumber(number));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Input number is negative");
                    }
                }
                break;
            case 2:
                {
                    //Second task
                    Console.Write("How many numbers you want to input? ");
                    int n = int.Parse(Console.ReadLine());
                    int[] intArray = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        intArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(ReturnAverageNumber(intArray));
                }
                break;
            case 3:
                {
                    //Third task
                    Console.Write("Please enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("{0}x+{1}=0 --> x = {2}", a, b, SolveLinearEquation(a, b));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Input number a is equal to 0!");
                    }
                }
                break;
            default: Console.WriteLine("The input choice is unavailable!"); break;
        }
    }

    static int  ReverseNumber(int  inputNumber)
    {
        if (inputNumber > 0)
        {
            List<int > tempList = new List<int >();
            int  tempDigit = 0;

            while (inputNumber > 0)
            {
                tempDigit = inputNumber % 10;
                inputNumber = inputNumber / 10;
                tempList.Add(tempDigit);
            }
            for (int i = 0; i < tempList.Count; i++)
            {
                inputNumber = inputNumber + (tempList[i] * (int)Math.Pow(10, (tempList.Count - i - 1)));
            }
            return inputNumber;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Input number is negative");
        }
        
    }

    static double ReturnAverageNumber(int[] intArray)
    {
        int sum = 0;
        double counter = 0.0d;
        double average = 0.0d;
        foreach (int element in intArray)
        {
            sum += element;
            counter++;
        }
        return average = sum / counter;
    }

    static double SolveLinearEquation(double a, double b)
    {
        double x = 0;
        if (a != 0)
        {
            return x = -b / a;
        }
        throw new ArgumentOutOfRangeException("Number must be not equal to 0");
    }
}
