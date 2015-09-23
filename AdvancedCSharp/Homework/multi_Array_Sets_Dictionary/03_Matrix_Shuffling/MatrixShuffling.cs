using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixShuffling
{
    private static int numRows = 0;
    private static int numCols = 0;
    private static string[,] matrix;
    static void Main()
    {
        numRows = int.Parse(Console.ReadLine().Trim());
        numCols = int.Parse(Console.ReadLine().Trim());
        matrix = new string[numRows, numCols];
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                matrix[row, col] = Console.ReadLine().Trim();
            }
        }

        string command = Console.ReadLine().ToUpper();
        while (command != "END")
        {
            string[] cmdItems = command.Split();
            if (!validCommand(cmdItems))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int rowFrom = int.Parse(cmdItems[1]);
                int colFrom = int.Parse(cmdItems[2]);
                int rowTo = int.Parse(cmdItems[3]);
                int colTo = int.Parse(cmdItems[4]);
                SwapValues(rowFrom, colFrom, rowTo, colTo);
                PrintMatrix();
            }
            command = Console.ReadLine().ToUpper();
        }
    }

    private static bool validCommand(string[] cmdItems)
    {
        if (cmdItems.Length != 5 || cmdItems[0] != "SWAP")
        {
            return false;
        }

        int rowFrom = int.Parse(cmdItems[1]);
        int colFrom = int.Parse(cmdItems[2]);
        int rowTo = int.Parse(cmdItems[3]);
        int colTo = int.Parse(cmdItems[4]);

        if (!(rowFrom >= 0 && rowFrom < numRows))
        {
            return false;
        }
        if (!(rowTo >= 0 && rowTo < numRows))
        {
            return false;
        }
        if (!(colFrom >= 0 && colFrom < numCols))
        {
            return false;
        }
        if (!(colTo >= 0 && colTo < numCols))
        {
            return false;
        }

        return true;
    }

    private static void SwapValues(int rowFrom, int colFrom, int rowTo, int colTo)
    {
        string buffer = matrix[rowFrom, colFrom];
        matrix[rowFrom, colFrom] = matrix[rowTo, colTo];
        matrix[rowTo, colTo] = buffer;
    }

    private static void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

