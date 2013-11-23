// 21. Write a program that reads a string from the console and prints all different letters in the 
// string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class CountAndSaveLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        var result = new Dictionary<string, int>();
        string pattern = @"\w";
        var match = Regex.Matches(input, pattern);


        foreach (Match letter in match)
        {
            if (result.ContainsKey(letter.Value))
            {
                result[letter.Value]++;
            }
            else
            {
                result.Add(letter.Value, 1);
            }
        }

        foreach (var pair in result)
        {
            Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
        }
    }
}
