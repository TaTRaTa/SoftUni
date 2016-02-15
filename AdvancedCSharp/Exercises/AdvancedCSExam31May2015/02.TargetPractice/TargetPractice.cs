using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TargetPractice
{
    class TargetPractice
    {
        static void Main()
        {
            string[] rowsAndCols = Console.ReadLine().Split();
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            string snake = Console.ReadLine();
            string[] shotParams = Console.ReadLine().Split();
            char[,] matrix = new char[rows, cols];
            int roll = 0;

            FillTheMatrix(matrix, rows, snake, roll);

            ExecuteShot(matrix, shotParams);

            ReplaceCharacter(matrix);

            TestResult(matrix);
        }

        private static void ReplaceCharacter(char[,] matrix)
        {
            for (int i = matrix.GetLength(0) - 2; i >= 0; i--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool isFall = true;
                    int row = i + 1;
                    while (isFall)
                    {
                        if (matrix[row, col] == ' ')
                        {
                            matrix[row, col] = matrix[row - 1, col];
                            matrix[row - 1, col] = ' ';
                            row++;
                            if (row == matrix.GetLength(0))
                            {
                                isFall = false;
                            }
                        }
                        else
                        {
                            isFall = false;
                        }
                    }
                }
            }
        }

        private static void ExecuteShot(char[,] matrix, string[] shotParams)
        {
            int r = int.Parse(shotParams[2]);
            int row = int.Parse(shotParams[0]);
            int col = int.Parse(shotParams[1]);

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (r*r >= Math.Pow(x - row, 2) + Math.Pow(y - col, 2))
                    {
                        matrix[x, y] = ' ';
                    }
                }
            }
        }

        private static void TestResult(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrix(char[,] matrix, int rows, string snake, int roll)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if ((row + 1) % 2 == rows % 2)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[roll % snake.Length];
                        roll++;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[roll % snake.Length];
                        roll++;
                    }
                }
            }
        }
    }
}
