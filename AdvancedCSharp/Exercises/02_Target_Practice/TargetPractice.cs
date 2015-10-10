using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class TargetPractice
{
    public static int[] dimensions;
    public static string snake = String.Empty;
    public static int[] rowColRadius;
    static void Main()
    {
        dimensions = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        snake = Regex.Replace(Console.ReadLine(), @"\s+", "");
        rowColRadius = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        char[,] matrix = new char[dimensions[0], dimensions[1]];

        FillTheMatrix(matrix);

        ExecuteShot(matrix);

        ReplaceAllCharacters(matrix);

        PrintTheMatrix(matrix);        
    }

    private static void ReplaceAllCharacters(char[,] matrix)
    {
        for (int i = matrix.GetLength(0) - 2; i >= 0; i--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                bool canFall = true;
                int row = i + 1;
                while (canFall)
                {
                    if (matrix[row, col] == ' ')
                    {
                        matrix[row, col] = matrix[row - 1, col];
                        matrix[row - 1, col] = ' ';
                        row++;
                        if (row == matrix.GetLength(0))
                        {
                            canFall = false;
                        }
                    }
                    else
                    {
                        canFall = false;
                    }
                }
            }
        }
    }

    private static void ExecuteShot(char[,] matrix)
    {
        int r = rowColRadius[2];
        int row = rowColRadius[0];
        int col = rowColRadius[1];
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                
                if ( r * r >= Math.Pow(x - row, 2) + Math.Pow(y - col, 2))
                {
                    matrix[x,y] = ' ';                  
                }               
            }
        }
    }

    private static void PrintTheMatrix(char[,] matrix)
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

    private static void FillTheMatrix(char[,] matrix)
    {
        int k = 0;
        int count = 0;
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--, count++)
        {           
            if (count % 2 == 0)
            {               
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {                    
                    matrix[i, j] = snake[k % snake.Length];
                    k++;
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = snake[k%snake.Length];
                    k++;
                }
            }
        }
    }
}

