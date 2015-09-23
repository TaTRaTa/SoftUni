using System;
using System.Linq;
//using System.Runtime.InteropServices.WindowsRuntime;

class MaximalSum
{
    static void Main()
    {
        int[] nAndm = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int n = nAndm[0];
        int m = nAndm[1];
        int[,] matrix = new int[n, m];

        matrix = PutInDigitToMatrix(matrix, n, m); // (1)

        PrintMaxSumAndMatrix3x3(matrix); // (2) and (3)      
    }

    static int[,] PutInDigitToMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            string[] numbersInRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(numbersInRow[j]);
            }
        }
        return matrix;
    }

    static void PrintMaxSumAndMatrix3x3(int[,] matrix)
    {
        int MaxValue = int.MinValue;
        int sum = 0;
        int maxSumRow = 0;
        int maxSumCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > MaxValue)
                {
                    MaxValue = sum;
                    maxSumRow = row;
                    maxSumCol = col;
                }
            }
        }
        Console.WriteLine("Sum = {0}", MaxValue);
        PrintMatrix3x3(matrix, maxSumRow, maxSumCol);
    }

    static void PrintMatrix3x3(int[,] matrix, int maxSumRow, int maxSumCol)
    {
        for (int row = maxSumRow; row < maxSumRow + 3; row++)
        {
            for (int col = maxSumCol; col < maxSumCol + 3; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}