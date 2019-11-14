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
            string cell;
            while (true)
            {
                try
                {
                    Console.Write("Enter cell#1: ");
                    cell = Console.ReadLine();
                    CheckInputString(cell);
                    ChessCell cell1 = new ChessCell(cell);//inicialization of first cell
                    Console.WriteLine($"{cell1} is {cell1.GetColor()}");//output the color of the first cell

                    Console.Write("Enter cell#2: ");
                    cell = Console.ReadLine();
                    CheckInputString(cell);
                    ChessCell cell2 = new ChessCell(cell);//inicialization of second cell
                    Console.WriteLine($"{cell2} is {cell2.GetColor()}");//output the color of the second cell

                    RelativePositionResercher resercher = new RelativePositionResercher();
                    Console.WriteLine(resercher.RelativePositionResearch(cell1, cell2));//comparing positions of first and second cell
                    break;
                }
                catch (InvalidFormatOfChessCell ex)//catch custom exception
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (Exception ex)//catch all other exception
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
            }
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
