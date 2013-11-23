using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public static class CompareList
    {
        // 7.Define method Min<T>
        public static T Min<T>(this GenericList<T> list)
        {
            if (list.Position == 0)
            {
                throw new InvalidOperationException("There aren't elements!");
            }

            else if (list.Position == 1)
            {
                return list[0];
            }

            else
            {
                T min = list[0];
                for (int i = 1; i < list.Position; i++)
                {
                    if ((min as IComparable<T>).CompareTo(list[i]) > 0)
                    {
                        min = list[i];
                    }
                }

                return min;
            }
        }

        // 7.Define method Max<T>
        public static T Max<T>(this GenericList<T> list)
        {
            if (list.Position == 0)
            {
                throw new InvalidOperationException("There aren't elements!");
            }

            else if (list.Position == 1)
            {
                return list[0];
            }

            else
            {
                T max = list[0];
                for (int i = 1; i < list.Position; i++)
                {
                    if ((max as IComparable<T>).CompareTo(list[i]) < 0)
                    {
                        max = list[i];
                    }
                }

                return max;
            }
        }
    }
}
