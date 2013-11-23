using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.MathFunctions
{
    public class Subtract
    {
        public static void SubtractInt(int endValue, int step)
        {
            int i = int.MaxValue;
            while (i > endValue)
            {
                i -= step;
            }
        }

        public static void SubtractLong(long endValue, long step)
        {
            long i = long.MaxValue;
            while (i > endValue)
            {
                i -= step;
            }
        }

        public static void SubtractFloat(float endValue, float step)
        {
            float i = float.MaxValue;
            while (i > endValue)
            {
                i -= step;
            }
        }

        public static void SubtractDouble(double endValue, double step)
        {
            double i = double.MaxValue;
            while (i > endValue)
            {
                i -= step;
            }
        }

        public static void SubtractDecimal(decimal endValue, decimal step)
        {
            decimal i = decimal.MaxValue;
            while (i > endValue)
            {
                i -= step;
            }
        }
    }
}
