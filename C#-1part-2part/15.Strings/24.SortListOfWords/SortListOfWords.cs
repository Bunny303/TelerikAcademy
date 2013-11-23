// 24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class SortListOfWords
{
    static void Main()
    {
        string list = "dog   cat  rabbit fish   sneak";
        string pattern = @"\w+";

        var match = Regex.Matches(list, pattern);
        var words = new List<string>();

        foreach (Match word in match)
        {
            words.Add(word.Value);
        }
        words.Sort();

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
