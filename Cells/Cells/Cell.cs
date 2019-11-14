
namespace Cells
{
    class Cell
    {
        char column;
        int row;
        public Cell(char column, int row)
        {
            if (column < 'a' || column > 'h' || row < 1 || row > 8)
                throw new OutOfChessBoardExeption("Out of desk.");//throwing exeption
            this.column = column;
            this.row = row;
        }
    }
}
