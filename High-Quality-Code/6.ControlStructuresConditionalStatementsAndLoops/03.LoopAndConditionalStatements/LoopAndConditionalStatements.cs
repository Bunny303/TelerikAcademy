using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LoopAndConditionalStatements
{
    public class LoopAndConditionalStatements
    {
        bool expectedValueFound = false;
        for (int index = 0; index < 100; index++) 
        {
            Console.WriteLine(array[index]);
    
            if (index % 10 == 0)
            {
                if (array[index] == expectedValue) 
                {
                    expectedValueFound = true;
                    break;
	            }
            }
        }

        if (expectedValueFound)
        {
            Console.WriteLine("Value Found!");
        }
    }
}
