using System;
using System.Collections.Generic;
using System.Text;

namespace StringCheck
{
    class NotRussianSymbolException : Exception
    {
        public NotRussianSymbolException(string message) : base(message) { }
    }
}
