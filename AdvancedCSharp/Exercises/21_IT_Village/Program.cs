using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _21.IT_Village
{
    class Program
    {
        public static char[,] board;
        public static int totalInn = 0;

        public class Player
        {
            public long Coins { get; set; }
            public bool isNakov { get; set; }
            public int SkipRoll { get; set; }
            public int Inn { get; set; }
            public int CurrRow { get; set; }
            public int CurrCol { get; set; }
        }

        static void Main()
        {
            string[] boardPosition = Console.ReadLine().Split('|');
            int[] startCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] dice = Console.ReadLine().Split().Select(int.Parse).ToArray();

            board = new char[4, 4];
            Player player = new Player();
            player.Coins = 50;
            player.CurrRow = startCoordinates[0] - 1;
            player.CurrCol = startCoordinates[1] - 1;
            player.isNakov = false;

            FillTheBoard(player, boardPosition);

            foreach (int luck in dice)
            {
                int roll = luck;

                if (player.SkipRoll == 0)
                {
                    if (player.Inn > 0)
                    {
                        player.Coins += 20 * player.Inn;
                    }
                    MovePosition(roll, player);
                    GameBoard(player);
                }
                else
                {
                    player.SkipRoll++;
                }

                if (player.isNakov)
                {
                    Console.WriteLine("<p>You won! Nakov's force was with you!<p>");
                    Environment.Exit(0);
                }

                if (player.Inn == totalInn)
                {
                    Console.WriteLine("<p>You won! You own the village now! You have {0} coins!<p> ", player.Coins);
                    Environment.Exit(0);
                }

                if (player.Coins < 0)
                {
                    Console.WriteLine("<p>You lost! You ran out of money!<p>");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("<p>You lost! No more moves! You have {0} coins!<p> ", player.Coins);


        }

        private static void MovePosition(int roll, Player player)
        {
            while (roll > 0)
            {
                if (roll > 0 && player.CurrRow == 0)
                {
                    while (roll > 0 && player.CurrCol < 3)
                    {
                        roll--;
                        player.CurrCol++;
                    }
                }

                if (roll > 0 && player.CurrCol == 3)
                {
                    while (roll > 0 && player.CurrRow < 3)
                    {
                        roll--;
                        player.CurrRow++;
                    }
                }

                if (roll > 0 && player.CurrRow == 3)
                {
                    while (roll > 0 && player.CurrCol > 0)
                    {
                        roll--;
                        player.CurrCol--;
                    }
                }

                if (roll > 0 && player.CurrCol == 0)
                {
                    while (roll > 0 && player.CurrRow > 0)
                    {
                        roll--;
                        player.CurrRow--;
                    }
                }
            }
        }

        private static void GameBoard(Player player)
        {
            switch (board[player.CurrRow, player.CurrCol])
            {
                case 'P':
                    //Wi-Fi pub 
                    player.Coins -= 5;
                    break;
                case 'I':

                    //Wi-Fi Inn 
                    if (player.Coins >= 100)
                    {
                        player.Coins -= 100;
                        player.Inn++;
                    }
                    else
                    {
                        player.Coins -= 10;
                    }
                    break;
                case 'F':
                    //Freelance Project 
                    player.Coins += 20;
                    break;
                case 'S':
                    //Storm 
                    player.SkipRoll -= 2;

                    break;
                case 'V':
                    //Super Vlado 
                    player.Coins *= 10;
                    break;
                case 'N':
                    player.isNakov = true;
                    break;
            }
        }

        private static void FillTheBoard(Player player, string[] boardPosition)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string temp = boardPosition[i];
                temp = Regex.Replace(temp, " ", "");
                for (int col = 0; col < temp.Length; col++)
                {
                    if (temp[col] == 'I')
                    {
                        totalInn++;
                    }
                    board[i, col] = temp[col];
                }
            }
        }
    }
}
