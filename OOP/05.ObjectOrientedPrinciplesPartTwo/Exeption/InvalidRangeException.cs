using System;
using System.Linq;

namespace Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; private set; }
        public T End { get; private set; }

        public InvalidRangeException(T start, T end)
            : base()
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
        
    }
}
