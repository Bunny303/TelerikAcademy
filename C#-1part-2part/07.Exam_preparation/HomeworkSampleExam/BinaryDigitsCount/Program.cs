using System;

    class Program
    {
        static void Main()
        {
            //Input
            byte b = byte.Parse(Console.ReadLine());
            ushort n = ushort.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                uint inputNumber = uint.Parse(Console.ReadLine());
                //Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
                int counter = 0;
                //Check
                while (inputNumber != 0)
                {
                    if ((inputNumber & 1) == b)
                    {
                        counter++;
                    }
                    inputNumber = inputNumber >> 1;
                }
                
                //Output
                Console.WriteLine(counter);
            }
            
        }
    }

