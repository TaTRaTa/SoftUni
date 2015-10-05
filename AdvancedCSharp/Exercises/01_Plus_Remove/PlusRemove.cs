using System;
using System.Collections.Generic;


class PlusRemove
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char[]> ch = new List<char[]>();
        var removeChar = new List<char[]>();

        while (input.ToUpper() != "END")
        {
            ch.Add(input.ToCharArray());
            removeChar.Add(input.ToCharArray());
            input = Console.ReadLine();
        }
        
                                                                    //int count = 0;
        for (int row = 0; row < ch.Count; row++)
        {
            for (int col = 0; col < ch[row].Length; col++)
            {
                if (IsMatch(ch, row, col))
                {
                                                                    //count++;
                    removeChar[row][col] = '\0';
                    removeChar[row - 1][col] = '\0';
                    removeChar[row + 1][col] = '\0';
                    removeChar[row][col - 1] = '\0';
                    removeChar[row][col + 1] = '\0';
                }
            }
        }
                                                                    //Console.WriteLine(count);

        foreach (var row in removeChar)
        {
            foreach (char col in row)
            {
                                                                //Console.Write(col);
                if (col != '\0')
                {
                    Console.Write(col);
                }
            }
            Console.WriteLine();
        }
    }

    static bool IsMatch(List<char[]> ch, int row, int col)
    {
        if (   (0 <= row - 1 && col < ch[row - 1].Length 
                && ch[row - 1][col].ToString().ToUpper() == ch[row][col].ToString().ToUpper())
            && (ch.Count > row + 1 && col < ch[row + 1].Length 
                && ch[row + 1][col].ToString().ToUpper() == ch[row][col].ToString().ToUpper())
            && (0 <= col - 1 && row >= 0
                && ch[row][col - 1].ToString().ToUpper() == ch[row][col].ToString().ToUpper())
            && (ch[row].Length > col + 1 && row >= 0
                && ch[row][col + 1].ToString().ToUpper() == ch[row][col].ToString().ToUpper()))

            {
                return true;
            }
        else
            {
                return false;
            }
    }
}

