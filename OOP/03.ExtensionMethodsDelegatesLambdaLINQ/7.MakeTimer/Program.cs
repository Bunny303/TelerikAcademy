using System;
using System.Linq;

namespace _7.MakeTimer
{
    class Program
    {
        static void Main()
        {
            Timer.ExecutedMethod(Printing, 3, 12);            
        }

        public static void Printing()
        {
            Console.WriteLine("Tro lo lo");
        }
   
    }

}
