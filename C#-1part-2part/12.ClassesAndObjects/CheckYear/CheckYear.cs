//1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class CheckYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int inputYear = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(inputYear);
        //Console.WriteLine(isLeap);
    }
}
