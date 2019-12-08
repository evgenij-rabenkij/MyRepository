using System;

namespace StringTranslit
{
    public class InvalidSymbolStringException : Exception
    {
        public InvalidSymbolStringException(string message) : base(message) { }
    }
}
