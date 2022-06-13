using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 3;
            int columnCount = 3;
            int[,] matrix = new int[rowCount, columnCount];
            FillMatrix(ref matrix, rowCount,columnCount);
            ShowMatrix(ref matrix, rowCount,columnCount);
            int column = GetColumn(ref matrix, rowCount, columnCount);
            Console.WriteLine(column);
            int[,] rezMatrix = BuildMatrix(matrix, rowCount,columnCount, GetColumn(ref matrix, rowCount,columnCount));
            ShowMatrix(ref rezMatrix, column, columnCount);
        }
        static void FillMatrix(ref int[,] matrix, int rowCount, int columnCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int[,] BuildMatrix(int[,]inputMatrix, int rowCount, int columnCount, int column)
        {
            int rowSize = column;
            int[,]matrix = new int[rowCount, columnCount];
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = inputMatrix[i, j];
                }
            }
            return matrix;
        }
        static int GetColumn(ref int[,] matrix, int rowCount, int columnCount)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < rowCount; i++)
            {
                int sum = 0;
                for (int j = 0; j < columnCount; j++)
                {
                    sum += matrix[j, i];
                }
                if(sum > max)
                {
                    max = sum;
                    index = i;
                }
            }
            return index;
        }
        static void ShowMatrix(ref int[,] matrix, int rowCount, int columnCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
} 