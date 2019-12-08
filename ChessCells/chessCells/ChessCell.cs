
namespace ChessCells
{
    class ChessCell
    {
        public char Column { get; }
        public int Row { get; }

        public ChessCell(string cell)
        {
            Column = cell[0];
            Row = (int)char.GetNumericValue(cell[1]);
        }

        public string GetColor()//method, which get cell and return its color
        {
            if ((Column + 1 - 'a') % 2 == Row % 2)
            {
                return "Black";
            }
            else
            {
                return "White";
            }
        }

        public override bool Equals(object obj)
        {
            return Column == (obj as ChessCell).Column && Row == (obj as ChessCell).Row;
        }

        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}
