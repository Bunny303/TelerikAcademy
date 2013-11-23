using System;
using System.Linq;

namespace Exception
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            try
            {
                int number = ReadNumber(start, end);
                Console.WriteLine("The umber is: {0}", number);
            }
            catch (InvalidRangeException<int> exeption)
            {
                Console.WriteLine(exeption.Message);
            }

            try
            {
                DateTime date = ReadDate(startDate, endDate);
                Console.WriteLine("The date is: {0}", date);
            }
            catch (InvalidRangeException<DateTime> exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }

        public static int ReadNumber(int start, int end)
        {
            Console.Write("Enter an integer number [{0}..{1}]: ", start, end);
            int number = int.Parse(Console.ReadLine());
            
            if ((number < start) || (number > end))
            {
                throw new InvalidRangeException<int>("Input number is out of range.", start, end);
            }
            return number;
        }

        public static DateTime ReadDate(DateTime start, DateTime end)
        {
            Console.Write("Enter a date [{0}..{1}]: ", start, end);
            DateTime date = DateTime.Parse(Console.ReadLine());
            if ((date < start) || (date > end))
            {
                throw new InvalidRangeException<DateTime>("Input date is out of range.", start, end);
            }
            return date;
        }


    }
}
