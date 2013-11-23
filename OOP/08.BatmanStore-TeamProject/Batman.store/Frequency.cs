using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public struct Frequency
    {
        //for example 24kHz-120kHz
        public int LowerLimit { get; private set; }
        public int HigherLimit { get; private set; }

        public Frequency(int lower, int higher)
            : this()
        {
            this.LowerLimit = lower;
            this.HigherLimit = higher;
        }

        public override string ToString()
        {
            return String.Format("{0}kHz - {1}kHz", LowerLimit, HigherLimit);
        }
    }
}
