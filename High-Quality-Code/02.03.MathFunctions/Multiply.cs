using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.MathFunctions
{
    public class Multiply
    {
        public static void MultiplyInt(int endValue, int step)
        {
            int i = 1;
            while (i < endValue)
            {
                i *= step;
            }
        }

        public static void MultiplyLong(long endValue, long step)
        {
            long i = 1;
            while (i < endValue)
            {
                i *= step;
            }
        }

        public static void MultiplyFloat(float endValue, float step)
        {
            float i = 1;
            while (i < endValue)
            {
                i *= step;
            }
        }

        public static void MultiplyDouble(double endValue, double step)
        {
            double i = 1;
            while (i < endValue)
            {
                i *= step;
            }
        }

        public static void MultiplyDecimal(decimal endValue, decimal step)
        {
            decimal i = 1;
            while (i < endValue)
            {
                i *= step;
            }
        }
    }
}
