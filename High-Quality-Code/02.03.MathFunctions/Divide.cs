using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.MathFunctions
{
    public class Divide
    {
        public static void DivideInt(int endValue, int step)
        {
            int i = int.MaxValue;
            while (i > endValue)
            {
                i /= step;
            }
        }

        public static void DivideLong(long endValue, long step)
        {
            long i = long.MaxValue;
            while (i > endValue)
            {
                i /= step;
            }
        }

        public static void DivideFloat(float endValue, float step)
        {
            float i = float.MaxValue;
            while (i > endValue)
            {
                i /= step;
            }
        }

        public static void DivideDouble(double endValue, double step)
        {
            double i = double.MaxValue;
            while (i > endValue)
            {
                i /= step;
            }
        }

        public static void DivideDecimal(decimal endValue, decimal step)
        {
            decimal i = decimal.MaxValue;
            while (i > endValue)
            {
                i /= step;
            }
        }
    }
}
