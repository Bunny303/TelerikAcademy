// 9. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class DeleteOddLines
{
    static void Main()
    {
        //Read input file , write odd lines to new tex file
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            int lineNumber = 1;
            using (StreamWriter writer = new StreamWriter(@"..\..\testTemp.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    if (lineNumber % 2 == 0)
                    {
                        writer.WriteLine(line);
                    }
                    lineNumber++;
                }
            }
        }

        // More effective way if we have big file
        //Delete input file and rename the new one
        File.Delete(@"../../test.txt");
        File.Move(@"../../testTemp.txt", @"../../test.txt");
   }
}
