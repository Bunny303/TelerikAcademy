using System;


namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Please, type your age at the moment:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("After ten years you will be: {0}", years + 10);
        }
    }
}
