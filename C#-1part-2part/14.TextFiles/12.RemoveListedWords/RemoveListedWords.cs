// 12. Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RemoveListedWords
{
    static void Main()
    {

        try
        {
            List<string> list = new List<string>();
            using (StreamReader words = new StreamReader("../../List.txt"))
            {
                for (string word = words.ReadLine(); word != null; word = words.ReadLine())
                {
                    list.Add(word);
                }
            }
            using (StreamReader reader = new StreamReader("../../test.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../testTemp.txt"))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        foreach (var s in list)
                        {
                            line = line.Replace(s, "");
                        }

                        writer.Write(line);
                    }
                }
            }
            File.Delete(@"../../test.txt");
            File.Move(@"../../testTemp.txt", @"../../test.txt");
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
