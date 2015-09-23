using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    private static int n = 0;
    private static int m = 0;
    private static string[,] matrix;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        matrix = new string[n, m];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }


        int maxLen = 1, maxRow = 0, maxCol = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int numEqual = CountEqual(row, col);
                if (numEqual > maxLen)
                {
                    maxLen = numEqual;
                    maxCol = col;
                    maxRow = row;
                }
            }
        }
        PrintSequence(maxLen, maxRow, maxCol);
    }

    private static int CountEqual(int row, int col)
    {
        string currentMatrix = matrix[row, col];
        int n = row, m = col, maxSize = 1, seqSize = 1;

        while (m < matrix.GetLength(1) - 1 && currentMatrix == matrix[row, m + 1])
        {
            m++;
            seqSize++;
        }
        maxSize = CheckBigger(seqSize, maxSize);


        seqSize = 1;
        while (n < matrix.GetLength(0) - 1 && currentMatrix == matrix[n + 1, col])
        {
            n++;
            seqSize++;
        }
        maxSize = CheckBigger(seqSize, maxSize);

        seqSize = 1; n = row; m = col;
        while (n < matrix.GetLength(0) - 1 && m < matrix.GetLength(1) - 1 && currentMatrix == matrix[n + 1, m + 1])
        {
            n++;
            m++;
            seqSize++;
        }
        maxSize = CheckBigger(seqSize, maxSize);

        seqSize = 1; n = row; m = col;
        while (n < matrix.GetLength(0) - 1 && m > 0 && currentMatrix == matrix[n + 1, m - 1])
        {
            n++;
            m--;
            seqSize++;
        }
        maxSize = CheckBigger(seqSize, maxSize);

        return maxSize;

    }

    static int CheckBigger(int seqSize, int maxSize)
    {
        if (seqSize > maxSize)
        {
            return seqSize;
        }
        return maxSize;
    }

    static void PrintSequence(int maxLen, int maxRow, int maxCol)
    {
        for (int i = 0; i < maxLen; i++)
        {
            Console.Write(matrix[maxRow, maxCol]);
            if (i < maxLen - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

