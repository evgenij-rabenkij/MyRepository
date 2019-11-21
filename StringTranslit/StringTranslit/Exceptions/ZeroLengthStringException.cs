using System;

namespace StringTranslit
{
    public class ZeroLengthStringException : Exception
    {
        public ZeroLengthStringException(string message) : base(message) { }
    }
}
