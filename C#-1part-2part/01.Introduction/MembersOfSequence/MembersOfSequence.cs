using System;


namespace MembersOfSequence
{
    class MembersOfSequence
    {
        static void Main()
        {
            Console.Write("The first ten members of sequence are: ");
            for (int a = 2; a <= 11; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a+" ");
                }
                else
                {
                    Console.Write(-a + " ");
                }
            }
            Console.WriteLine(";");
        }
    }
}
