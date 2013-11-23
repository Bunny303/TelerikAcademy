// 22. Write a program that reads a string from the console and lists all different words in the 
// string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class CountAndSaveWords
{
    static void Main()
    {
        string input = Console.ReadLine();

        var result  = new Dictionary<string, int>();
        string pattern = @"\w+";
        var match = Regex.Matches(input, pattern);
        

        foreach (Match word in match)
        {
            if (result.ContainsKey(word.Value))
            {
                result[word.Value]++;
            }
            else
            {
                result.Add(word.Value, 1);
            }
        }

        foreach (var pair in result)
        {
            Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
        }
    }
}