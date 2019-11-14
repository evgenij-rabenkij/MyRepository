using System;

namespace Cells
{
    class OutOfChessBoardExeption : Exception
    {
        public OutOfChessBoardExeption(string message) : base(message) { }
    }
}
