// 3. Write a program that reads a text file and inserts line numbers in front of each 
//of its lines. The result should be written to another text file.

using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {           
            using (StreamWriter writer = new StreamWriter(@"..\..\newCreatedFile.txt"))
            {
                 int counter = 1;
                 for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
                 {
                     writer.Write(counter);
                     writer.WriteLine(line);
                     counter++;
                 }

            }

        }
    }
}
