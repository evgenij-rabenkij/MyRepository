using System;

namespace Cells
{
    class Program
    {
        static void Main(string[] args)
        {
            char column;
            int  row;

            while (true)
            {
                try
                {
                    Console.Write("Column: ");
                    column = char.Parse(Console.ReadLine());
                    Console.Write("Row: ");
                    row = int.Parse(Console.ReadLine());

                    Cell cell = new Cell(column, row);//creating new cell
                    Console.WriteLine($"New cell: {column}{row}");
                    break;
                }
                catch (OutOfChessBoardExeption ex)//catch for OutOfChessBoardExeption
                {
                    Console.WriteLine(ex.Message + "Try again");
                }
                catch (FormatException ex)//catch for FormatException
                {
                    Console.WriteLine(ex.Message+"Try again");
                }
            }
        }
    }
}
