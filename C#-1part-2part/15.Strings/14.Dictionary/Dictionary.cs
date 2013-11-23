// 14. A dictionary is stored as a sequence of text lines containing words and their 
//explanations. Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string input = @".NET - platform for applications from Microsoft
                                CLR - managed execution environment for .NET
                                namespace - hierarchical organization of classes";

        Dictionary<string, string> dict = new Dictionary<string, string>();
        string[] words = input.Split((new char[] { '-', '\r', '\n' }), StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i = i + 2)
        {
            string word = words[i].Trim();
            string meaning = words[i + 1].Trim();
            dict.Add(word, meaning);
        }

        string searchingWord = Console.ReadLine();
        Console.WriteLine("{0}-{1} ", searchingWord, dict[searchingWord]);
    }
}
