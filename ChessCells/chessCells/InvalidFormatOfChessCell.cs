using System;

namespace ChessCells
{
    class InvalidFormatOfChessCell : Exception
    {
        public InvalidFormatOfChessCell(string message) : base(message) { }
    }
}
