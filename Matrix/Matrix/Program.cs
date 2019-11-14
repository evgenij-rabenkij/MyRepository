using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix;
            Console.Write("Size of matrix: ");

            sizeOfMatrix = Convert.ToInt32(Console.ReadLine());//reading and converting size of matrix from console input
            MyMatrix<int> intMatrix = new MyMatrix<int>(sizeOfMatrix);//initialization of new matrix

            intMatrix.elementChangedOrNot += DisplayMessage;//subscribing method to event
            
            intMatrix.MatrixOutput();//call method for outputting matrix
            intMatrix.IsDiagonal();//call method for checking diagonal of matrix 
            
            intMatrix[2, 2] = 0;//access to matrix elements through an indexer
            intMatrix[1, 3] = 0;//
            intMatrix[3, 3] = 1;//
            
            intMatrix.MatrixOutput();
        }
        private static void DisplayMessage(string message)//method for displaying messages in console
        {
            Console.WriteLine(message);
        }
    }
}
