using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.MathFunctions
{
    class Test
    {
        static void Main(string[] args)
        {
            Add.AddInt(10000, 2);
            Add.AddLong(10000L, 2);
            Add.AddFloat(10000f, 2);
            Add.AddDouble(10000d, 2);
            Add.AddDecimal(10000m, 2);

            Divide.DivideInt(1, 3);
            Divide.DivideLong(1L, 3L);
            Divide.DivideFloat(1f, 3f);
            Divide.DivideDouble(1d, 3d);
            Divide.DivideDecimal(1m, 3m);

            Increment.IncrementInt(10000);
            Increment.IncrementLong(10000L);
            Increment.IncrementFloat(10000f);
            Increment.IncrementDouble(10000d);
            Increment.IncrementDecimal(10000m);

            Multiply.MultiplyInt(10000, 2);
            Multiply.MultiplyLong(10000L, 2);
            Multiply.MultiplyFloat(10000f, 2);
            Multiply.MultiplyDouble(10000d, 2);
            Multiply.MultiplyDecimal(10000m, 2);

            Subtract.SubtractInt(1, 1000);
            Subtract.SubtractLong(1L, 10000L);
            Subtract.SubtractFloat(1f, 1000f);
            Subtract.SubtractDouble(1d, 1000d);
            Subtract.SubtractDecimal(1m, 1000m);
        }
    }
}
