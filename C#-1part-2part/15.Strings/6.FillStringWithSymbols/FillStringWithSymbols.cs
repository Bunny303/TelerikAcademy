// 6.Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

using System;
using System.Text;

class FillStringWithSymbols
{
    static void Main()
    {
        Console.Write("Enter text, max 20 symbols: ");
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            StringBuilder result = new StringBuilder();
            result.Append(input);

            for (int i = input.Length; i < 20; i++)
            {
                result.Append("*");
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}
