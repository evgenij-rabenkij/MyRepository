using System;
using System.Globalization;
using System.Threading;

namespace ChessCells
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            while (true)
            {
                try
                {
                    ChessCell cell1 = CellInput();//inicialization of first cell
                    Console.WriteLine($"{cell1} is {cell1.GetColor()}");//output the color of the first cell

                    ChessCell cell2 = CellInput();//inicialization of second cell
                    Console.WriteLine($"{cell2} is {cell2.GetColor()}");//output the color of the second cell

                    RelativePositionResercher resercher = new RelativePositionResercher();
                    Console.WriteLine(resercher.RelativePositionResearch(cell1, cell2));//comparing positions of first and second cell
                    break;
                }
                catch (InvalidFormatOfChessCell ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
            }
        }

        private static ChessCell CellInput()//method for new cell input
        {
            Console.Write("Enter cell: ");
            string cellInput = Console.ReadLine();
            CheckInputString(cellInput);
            ChessCell cell = new ChessCell(cellInput);
            return cell;
        }

        private static void CheckInputString(string cell)//method for checking validity of input string
        {
            const string files = "abcdefgh";
            const string ranks = "12345678";
            if (cell.Length != 2 || files.Contains(cell[0].ToString()) == false || ranks.Contains(cell[1].ToString()) == false)
                throw new InvalidFormatOfChessCell("Invalid format of chess cell.");
        }
    }
}
