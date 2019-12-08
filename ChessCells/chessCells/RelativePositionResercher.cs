using System;

namespace ChessCells
{
    class RelativePositionResercher//class, which contains method with realization of determination of relative position of two cells
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
            if (cell1.Column == cell2.Column)
            {
                return $"{cell1} and {cell2} lies in one column.";
            }
            if (cell1.Row == cell2.Row)
            {
                return $"{cell1} and {cell2} lies in one row.";
            }
            if (Math.Abs(cell1.Column - cell2.Column) == Math.Abs(cell1.Row - cell2.Row))
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
