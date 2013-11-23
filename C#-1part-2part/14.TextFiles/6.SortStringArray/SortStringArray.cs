// 6. Write a program that reads a text file containing a list of strings, sorts them and saves them to 
//another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SortStringArray
{
    static void Main()
    {
        //Declare array
        List<string> inputFile = new List<string>(); 

        //Read text file and save information in array
        using (StreamReader reader = new StreamReader(@"..\..\List.txt"))
        {
            for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
            {
                inputFile.Add(line);        
            }    
        }

        //Sort array
        inputFile.Sort();

        //Save sorted array to another text file
        using (StreamWriter writer = new StreamWriter(@"..\..\SortedList.txt"))
        for (int i = 0; i < inputFile.Count; i++)
        {
            writer.WriteLine(inputFile[i]);
        }

    }
}
