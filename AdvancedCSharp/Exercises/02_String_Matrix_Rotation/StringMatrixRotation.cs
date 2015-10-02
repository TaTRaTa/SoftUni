using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;


class StringMatrixRotation
{
    static void Main()
    {
        string rotate = Console.ReadLine();
        int numDegree = int.Parse(rotate.Substring(7, (rotate.Length - 1) - 7));
        List<char[]> list = new List<char[]>();

        string line = Console.ReadLine();
        while (line.ToUpper() != "END")
        {
            list.Add(line.ToCharArray());
            line = Console.ReadLine();
        }

        

        int formula = numDegree%360;
        switch (formula)
        {
            case 0:
                 First(list);
                break;
            case 90:
                Second(list);               
                break;
            case 180:
                Third(list);
                break;
            case 270:
                 Fourth(list);
                break;
        }
    }

    static void First(List<char[]> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Length; j++)
            {
                Console.Write(list[i][j]);
            }
            Console.WriteLine();
        }
    }

    static void Third(List<char[]> list)
    {
        int count = MaxV(list);
        
        for (int i = list.Count - 1; i >= 0; i--)
        {
            StringBuilder temp = new StringBuilder();           
            for (int j = list[i].Length - 1; j >= 0; j--)
            {
                    temp.Append(list[i][j]);
            }
            Console.WriteLine(temp.ToString().PadLeft(count));
        }
    }
    static void Second(List<char[]> list )
    {
        string[,] matrix = new string[list.Count(), MaxV(list)];
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Length; j++)
            {
                matrix[i, j] = list[i][j].ToString();
            }
        }
        for (int row = 0; row < MaxV(list); row++)
        {
            for (int col = list.Count - 1; col >= 0 ; col--)
            {
                if (matrix[col, row] == null)
                {
                    matrix[col, row] = " ";
                    Console.Write(matrix[col, row]);
                }
                else
                {
                    Console.Write(matrix[col, row]);
                }               
            }
            Console.WriteLine();
        }
    }

    static int MaxV(List<char[]> list)
    {
        int MaxValue = int.MinValue;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Count() > MaxValue)
            {
                MaxValue = list[i].Count();
            }            
        }
        return MaxValue;
    }

    static void Fourth(List<char[]> list)
    {
        string[,] matrix = new string[list.Count(), MaxV(list)];
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Length; j++)
            {
                matrix[i, j] = list[i][j].ToString();
            }
        }
        for (int row = MaxV(list) - 1; row >= 0 ; row--)
        {
            for (int col = 0; col < list.Count; col++)
            {
                if (matrix[col, row] == null)
                {
                    matrix[col, row] = " ";
                    Console.Write(matrix[col, row]);
                }
                else
                {
                    Console.Write(matrix[col, row]);
                }
            }
            Console.WriteLine();
        }
    }
}

