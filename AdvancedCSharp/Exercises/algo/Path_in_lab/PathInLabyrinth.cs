using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PathInLabyrinth
{
    private static char[,] lab =
    {
        {' ', ' ', ' ', '*', ' ', ' ', ' '},
        {'*', '*', ' ', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {' ', '*', '*', '*', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
    };

    static bool InRange(int row, int col)
    {
        bool rowInRange = row >= 0 && row < lab.GetLength(0);
        bool colInRange = col >= 0 && col < lab.GetLength(1);

        return rowInRange && colInRange;
    }

    static void Main()
    {
        PathToExit(0, 0);
    }

    private static void PathToExit(int row, int col)
    {

        if (!InRange(row, col))
        {
            return;
        }

        if (lab[row, col] == '*' || lab[row, col] == '.')
        {          
            return;
        }

        if (lab[row, col] == 'e')
        {
            PrintSolution();
            return;
        }

        lab[row, col] = '.';

        PathToExit(row - 1, col);
        PathToExit(row, col + 1);
        PathToExit(row + 1, col);
        PathToExit(row, col - 1);

        lab[row, col] = ' ';

    }

    private static void PrintSolution()
    {
        for (int row = 0; row < lab.GetLength(0); row++)
        {
            for (int col = 0; col < lab.GetLength(1); col++)
            {
                Console.Write(lab[row, col]);
            }
            Console.WriteLine();
        }
    }
}

