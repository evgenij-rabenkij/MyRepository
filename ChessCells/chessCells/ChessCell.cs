
namespace ChessCells
{
    class ChessCell
    {
        public char File { get; }
        public int Rank { get; }

        public ChessCell(string cell)
        {
            File = cell[0];
            Rank = (int)char.GetNumericValue(cell[1]);
        }

        public string GetColor()//method, which get cell and return its color
        {
            if ((File + 1 - 'a') % 2 == Rank % 2)
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
            return File == (obj as ChessCell).File && Rank == (obj as ChessCell).Rank;
        }

        public override string ToString()
        {
            return $"{File}{Rank}";
        }
    }
}
