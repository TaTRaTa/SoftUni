using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BunkerBuster
{
    class BunkerBuster
    {
        static void Main(string[] args)
        {
            int count = 0;
            int area = 0;
            string[] dimenson = Console.ReadLine().Split();
            int rows = int.Parse(dimenson[0]);
            int cols = int.Parse(dimenson[1]);
            area = rows * cols;
            int[,] matrix = new int[rows,cols];
            for (var k = 0; k < matrix.GetLength(0); k++)
            {
                string[] tempInts = Console.ReadLine().Split();
                for (int i = 0; i < cols; i++)
                {
                    matrix[k, i] = int.Parse(tempInts[i]);
                }
            }

            string command = Console.ReadLine();
            while (command != "cease fire!" )
            {
                string[] arg = command.Split();
                int row = int.Parse(arg[0]);
                int col = int.Parse(arg[1]);
                int power = char.Parse(arg[2]);                

                ExecuteBomb(power, row, col, rows, cols, matrix);

                command = Console.ReadLine();
            }
            
            foreach (int digit in matrix)
            {
                if (digit <= 0)
                {
                    count++;
                }
            }

            double per = ((double)count/area)*100;
            Console.WriteLine("Destroyed bunkers: {0}", count);
            if (per == 0)
            {
                Console.WriteLine("Damage done: {0} %", per);
            }
            else
            {
                Console.WriteLine("Damage done: {0:f1} %", per);
            }
            
        }

        private static void ExecuteBomb(int power, int row, int col, int rows, int cols, int[,] matrix)
        {
            int halfPower = (int) Math.Ceiling((double) power/2.0);
            int minRow = Math.Max(0, row - 1);
            int minCol = Math.Max(0, col - 1);
            int maxRow = Math.Min(rows - 1, row + 1);
            int maxCol = Math.Min(cols - 1, col + 1);
            matrix[row, col] -= power;

            if (minRow != row && minCol != col)
            {
                matrix[minRow, minCol] -= halfPower;
            }

            if (minRow != row)
            {
                matrix[minRow, col] -= halfPower;
            }

            if (minRow != row && maxCol != col)
            {
                matrix[minRow, maxCol] -= halfPower;
            }

            if (minCol != col)
            {
                matrix[row, minCol] -= halfPower;
            }

            if (maxCol != col)
            {
                matrix[row, maxCol] -= halfPower;
            }

            if (maxRow != row && minCol != col)
            {
                matrix[maxRow, minCol] -= halfPower;
            }

            if (maxRow != row)
            {
                matrix[maxRow, col] -= halfPower;
            }

            if (maxRow != row && maxCol != col)
            {
                matrix[maxRow, maxCol] -= halfPower;
            }
        }
    }
}
