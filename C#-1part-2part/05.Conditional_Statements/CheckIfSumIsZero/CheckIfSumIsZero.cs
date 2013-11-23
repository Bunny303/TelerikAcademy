//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 

using System;

    class CheckIfSumIsZero
    {
        static void Main()
        {
            // Input 5 integer numbers
            Console.Write("Please enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number: ");
            int e = int.Parse(Console.ReadLine());

                for (int i = 0; i < 2; i++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            for (int p = 0; p < 2; p++)
                            {
                                for (int q = 0; q < 2; q++)
                                {
                                    if ((i + k + j + p + q) > 1) //There is sum of given numbers only if there are minimum two numbers
                                    {
                                        int sum = 0;
                                        // Example: i=0, k=0, j=0, p=1, q=1 then 
                                        //sum=0*a+0*b+0*c+1*d+1*e => check if sum=d+e=0 and so on for all combination 
                                        //until find first and then stop.
                                        sum = i * a + k * b + j * c + p * d + q * e;

                                        if (sum == 0)
                                        {
                                            Console.WriteLine("The sum of some subset of given integer numbers is 0 ");
                                            return; //stop the loop, there is minimum one sum that is equal to zero
                                        }
                
                                    }
                                }
                            }
                        }
                    }
                }
        }
    }

