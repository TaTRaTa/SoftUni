using System;
using System.Collections.Generic;
using System.Linq;

class collectTheCoins
{
 static int currRow = 0, currCol = 0, sum = 0,     walls = 0;
 static char[][] board = new char[4][];

    static void Main()
    {      
        for (int i = 0; i < board.Length; i++)
            {
                List<char> line = new List<char>();
                line = Console.ReadLine().ToList();
                board[i] = line.ToArray();
            }

        char[] direction = Console.ReadLine().ToCharArray();

         WalkingInArrays(direction);

          Console.WriteLine("Coins collected: {0}\nWalls hit: {1}", sum, walls);

    }

    static void WalkingInArrays(char[] directions)
    {      
        foreach (char dir in directions)
            {
                switch (dir)
                {
                    case '^':    Top();       break;
                    case 'V':    Down();      break;
                    case '<':    Left();      break;
                    case '>':    Right();     break;
                }
            }
    }

    static void CheckAndCountForCoin()
    {
        if (board[currRow][currCol] == '$')
                {
                    sum++;
                }
    }

    static void Top()
    {
        if (currRow == 0)
            {
                walls++;
            }
        else
            {
                if (board[currRow - 1].Length - 1 < currCol)
                    {
                        walls++;
                    }
                else
                    {
                        currRow--;
                        CheckAndCountForCoin();
                    }
        }
    }

    static void Down()
    {
        if (currRow == 3)
            {
                walls++;
            }
        else
        {
            if (board[currRow + 1].Length - 1 < currCol)
                {
                    walls++;
                }
            else
                {
                    currRow++;
                    CheckAndCountForCoin();
                }
        }
    }

    static void Left()
    {
        if (currCol == 0)
            {
                walls++;
            }
        else
            {
                currCol--;
                CheckAndCountForCoin();
            }
    }

    static void Right()
    {
        if (currCol < board[currRow].Length - 1)
            {
                currCol++;
                CheckAndCountForCoin();
            }
        else
            {
                walls++;
            }
    }
}
