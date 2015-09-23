using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int digit = 1;
        char pattern = (char)Console.Read();
        pattern = RetunValueAorB(pattern);

        if (char.ToUpper(pattern) == 'A')
        {
            matrix = SequenceTopBottom(matrix, n, digit);
        }
        else if (char.ToUpper(pattern) == 'B')
        {
            matrix = SequencefromVariantB(matrix, n, digit);

        }

        PrintMatrix(matrix, n);

    }

    static char RetunValueAorB(char pattern)
    {

        while (char.ToUpper(pattern) != 'A' && char.ToUpper(pattern) != 'B')
        {
            pattern = (char)Console.Read();
        }
        return pattern;
    }

    static int[,] SequenceTopBottom(int[,] matrix, int n, int digit)
    {
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = digit;
                digit++;
            }
        }
        return matrix;
    }

    private static int[,] SequencefromVariantB(int[,] matrix, int n, int digit)
    {
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }

        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,5}", matrix[row, col]);

            }
            Console.WriteLine();
        }
    }
}