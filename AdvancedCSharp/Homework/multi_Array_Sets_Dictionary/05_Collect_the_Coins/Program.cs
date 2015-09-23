using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectTheCoins
{
    private static bool CoinFound(List<char>[] board, int rowInd, int colInd)
    {
        if (board[rowInd][colInd] == '$')
        {
            board[rowInd][colInd] = '*'; //mark as collected coin
            return true;
        }
        return false;
    }

    static void Main()
    {
        //init board
        List<char>[] board = new List<char>[4];
        for (int i = 0; i < 4; i++)
        {
            List<char> line = Console.ReadLine().Trim().ToCharArray().ToList();
            board[i] = line;
        }

        char[] directions = Console.ReadLine().Trim().ToCharArray();
        int currRow = 0, currCol = 0;
        int numCoins = 0, numWalls = 0;

        //walking
        foreach (char dir in directions)
        {
            switch (dir)
            {
                case '^':
                    if (currRow == 0)
                    {
                        numWalls++;
                    }
                    else
                    {
                        if (board[currRow - 1].Count - 1 < currCol)
                        {
                            numWalls++;
                        }
                        else
                        {
                            currRow--;
                            if (CoinFound(board, currRow, currCol))
                                numCoins++;
                        }
                    }
                    break;

                case 'V':
                    if (currRow == 3)
                    {
                        numWalls++;
                    }
                    else
                    {
                        if (board[currRow + 1].Count - 1 < currCol)
                        {
                            numWalls++;
                        }
                        else
                        {
                            currRow++;
                            if (CoinFound(board, currRow, currCol))
                                numCoins++;

                        }

                    }
                    break;

                case '>':
                    List<char> row = board[currRow];
                    if (currCol == row.Count - 1)
                    {
                        numWalls++;
                    }
                    else
                    {
                        currCol++;
                        if (CoinFound(board, currRow, currCol))
                            numCoins++;
                    }
                    break;

                case '<':
                    row = board[currRow];
                    if (currCol == 0)
                    {
                        numWalls++;
                    }
                    else
                    {
                        currCol--;
                        if (CoinFound(board, currRow, currCol))
                            numCoins++;
                    }
                    break;
            }
        }
        Console.WriteLine("Coins collected: {0}\nWalls hit: {1}", numCoins, numWalls);
    }
}