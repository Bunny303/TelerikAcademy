﻿using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Test xy = new Test();
            Type type = typeof(Test);

            object[] allAttributes =

              type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("{0}: {1}", attr, attr.Version);
            }
        }
    }
    [VersionAttribute(2.1)]
    public class Test
    {
        public int P { get; set; }
    }
}
