using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSum
{
    class Program
    {

        static void Main(string[] args)
        {   // Ввод количества рядов и столбцов матрицы.
            int rows;
            Console.Write("Matrix. Insert the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            int cols;
            Console.Write("Matrix. Insert the number of columns: ");
            cols = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            // Ввод элементов первой и второй матрицы.
            Console.WriteLine("Matrix 1. Insert the numbers: ");
            int[,] matrix1 = new int[rows, cols];
            FillMatrix(matrix1);

            Console.WriteLine("Matrix 2. Insert the numbers: ");
            int[,] matrix2 = new int[rows, cols];
            FillMatrix(matrix2);

            // Сложение двух матриц.
            int[,] matrixSum = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Вывод первой, второй матрицы и матрицы - результата суммы.
            Console.WriteLine("Matrix 1:");
            GetMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            GetMatrix(matrix2);

            Console.WriteLine("Matrix 1 + Matrix 2 =");
            GetMatrix(matrixSum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        // Метод заполнения матрицы.
        public static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Write matrix[{0}, {1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        // Метод вывода матрицы.
        public static void GetMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}