//4. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Text;
using System.Text.RegularExpressions;

class CountSameSubstrings
{
    static void Main()
    {
        string substring = "in";
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        int counter = Regex.Matches(text, substring, RegexOptions.IgnoreCase).Count;
                
        Console.WriteLine("Result: {0}", counter);
    }
}
