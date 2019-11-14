using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class MyMatrix<T> 
    {
        int size ;
        T[] matrix;

        public delegate void ChangeTheElement(string message);
        public event ChangeTheElement elementChangedOrNot;

        public MyMatrix(int size)
        {
            this.size = size;
            matrix = new T[size * size];

            Console.WriteLine("Enter elements of matrix: ");
            for (int i = 0; i < size * size; i++)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                matrix[i] = (T)(object)data;
            }

            if (matrix.Length != size * size)//checking size of matrix
            {
                Console.WriteLine("Error: not appropriate size of matrix.");
            }
            else
            {
                Console.WriteLine("Appropriate size of matrix.");
            } 
        }

        public bool IsDiagonal()//method for checking diagonal of matrix
        {
            int counter = 0;
            for (int i = 0; i < size * size; i++)
            {
                if (i % (size + 1) != 0 && matrix[i].GetType() == typeof(int) && (int)(object)matrix[i] == 0)
                {
                    counter++;
                }
            }
            
            if (counter == matrix.Length - size)
            {
                Console.WriteLine("Matrix is diagonal.");
                return true;
            }
            else 
            {
                Console.WriteLine("Matrix is not diagonal.");
                return false;
            }
        }

        public T this[int line, int column]//indexator
        {
            get
            {
                return matrix[size*(line-1)+column-1];
            }
            set
            {
                if ((int)(object)matrix[size * (line - 1) + column - 1] == (int)(object)value)
                {
                    elementChangedOrNot($"Element [{line}, {column}] already has this value.");
                }
                else 
                {
                    elementChangedOrNot($"Value of element [{line}, {column}] changed from {matrix[size * (line - 1) + column - 1]} to {value}.");
                    matrix[size * (line - 1) + column - 1] = value;
                }
            }
        }

        public void MatrixOutput()//method for outputting square matrix
        {
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < size*size; i+=size)
            {
                for (int j = i; j < i +size; j++)
                {
                    Console.Write(matrix[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
