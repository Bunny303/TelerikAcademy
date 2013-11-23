// 13. Write a program that reads a list of words from a file words.txt and finds how many times each of 
//the words is contained in another file test.txt. The result should be written in the file result.txt 
//and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class CountWordsFromList
{
    static void Main()
    {
        try
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            
            using (StreamReader words = new StreamReader(@"../../words.txt"))
            {
                for (string word = words.ReadLine(); word != null; word = words.ReadLine())
                {
                    dictionary.Add(word,0);
                }
            }

            using (StreamReader reader = new StreamReader(@"../../test.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    List<string> wordList = new List<string>(dictionary.Keys);
                    foreach (var word in wordList)
                    {
                        string regex = String.Format("\\b{0}\\b", word);
                        MatchCollection matches = Regex.Matches(line, @"\b" + word + @"\b");
                        dictionary[word] = dictionary[word] + matches.Count;
                    }
                }    
            }

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine(wordCounter.Key + ": " + wordCounter.Value + " times");
                }
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong file path");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file format");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access");
        }
    }
}
