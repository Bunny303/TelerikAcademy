using System;

class Program
{
    static void Main()
    {
        //Input
        uint a = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint c = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());

        //Calculate
        for (uint i = 1;true; i++)
            
            {
            byte counter = 0;
                if (i % a == 0)
                {
                    counter++;
                }
                if (i % b == 0)
                {
                    counter++;
                }
                if (i % c == 0)
                {
                    counter++;
                }
                if (i % d == 0)
                {
                    counter++;
                }
                if (i % e == 0)
                {
                    counter++;
                }
                if (counter >= 3)
                {
                    Console.WriteLine(i); 
                    break;
                }
            }
        
        
       
    }
}

