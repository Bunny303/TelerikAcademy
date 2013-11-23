using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class StoreException : ApplicationException
    {
        public StoreException(string msg)
            : base(msg, new ArgumentException())
        { }
    }
}
