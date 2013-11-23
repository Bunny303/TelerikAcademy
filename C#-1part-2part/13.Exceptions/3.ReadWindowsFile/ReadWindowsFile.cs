//3. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class ReadWindowsFile
{
    static void Main()
    {
        try
        {
            string fileContent = File.ReadAllText(@"C:\WINDOWS\win.ini");
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File path not found");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The ile path is incorrect");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("Don't have access to the file");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}
