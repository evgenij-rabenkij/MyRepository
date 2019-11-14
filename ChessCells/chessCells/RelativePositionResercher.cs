using System;

namespace ChessCells
{
    class RelativePositionResercher
    {
        public RelativePositionResercher()
        { 
        }

        public string RelativePositionResearch(ChessCell cell1, ChessCell cell2)//method for reserching relative position of two cells
        {
            if (cell1.Equals(cell2))
            {
                return $"{cell1} and {cell2} is the same cell.";
            }
            if (cell1.File ==cell2.File)
            {
                return $"{cell1} and {cell2} lies in one file.";
            }
            if (cell1.Rank == cell2.Rank)
            {
                return $"{cell1} and {cell2} lies in one rank.";
            }
            if (Math.Abs(cell1.File - cell2.File) == Math.Abs(cell1.Rank - cell2.Rank))
            {
                return $"{cell1} and {cell2} lies in one diagonal.";
            }
            else 
            {
                return $"Positions of {cell1} and {cell2} do not relate."; 
            }
        }
    }
}
