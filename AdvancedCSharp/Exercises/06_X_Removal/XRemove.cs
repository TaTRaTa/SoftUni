using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


class XRemove
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char[]> list = new List<char[]>();
        List<char[]> removeList = new List<char[]>();
        while (input.ToUpper() != "END")
        {
            list.Add(input.ToCharArray());
            removeList.Add(input.ToCharArray());
            input = Console.ReadLine();
        }

        for (int row = 0; row < list.Count; row++)
        {
            for (int col = 0; col < list[row].Length; col++)
            {
                if (IsMatch(list, row, col))
                {
                    removeList[row][col] = '\0';
                    removeList[row - 1][col - 1] = '\0';
                    removeList[row - 1][col + 1] = '\0';
                    removeList[row + 1][col - 1] = '\0';
                    removeList[row + 1][col + 1] = '\0';
                }
            }
        }

        foreach (var item  in removeList)
        {
            foreach (var element in item)
            {
                if (element != '\0')
                {
                    Console.Write(element);
                }                
            }
            Console.WriteLine();
        }
    }

    static bool IsMatch(List<char[]> list, int row, int col)
    {
        char center = list[row][col];
        if (row - 1 >= 0 && col - 1 >= 0
            && row + 1 < list.Count
            && col + 1 < list[row - 1].Length 
            && col + 1 < list[row + 1].Length )           
        {
            if (   char.ToUpper(list[row - 1][col - 1]) == char.ToUpper(center)
                && char.ToUpper(list[row - 1][col + 1]) == char.ToUpper(center)
                && char.ToUpper(list[row + 1][col - 1]) == char.ToUpper(center)
                && char.ToUpper(list[row + 1][col + 1]) == char.ToUpper(center))
            {
                return true;
            }


            return false;
        }
        else
        {
            return false;
        }
    }
}

