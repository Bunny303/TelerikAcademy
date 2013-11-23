using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.MathFunctions
{
    public class Add
    {
        public static void AddInt(int endValue, int step)
        {
            int i = 0;
            while (i < endValue)
            {
                i += step;
            }
        }

        public static void AddLong(long endValue, long step)
        {
            long i = 0;
            while (i < endValue)
            {
                i += step;
            }
        }

        public static void AddFloat(float endValue, float step)
        {
            float i = 0;
            while (i < endValue)
            {
                i += step;
            }
        }

        public static void AddDouble(double endValue, double step)
        {
            double i = 0;
            while (i < endValue)
            {
                i += step;
            }
        }

        public static void AddDecimal(decimal endValue, decimal step)
        {
            decimal i = 0;
            while (i < endValue)
            {
                i += step;
            }
        }
    }
}
