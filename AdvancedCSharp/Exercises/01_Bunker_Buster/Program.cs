using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    public static void Main()
    {
        int[] len = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[,] matrix = new int[len[0],len[1]];
        int[] line = new int[len[1]];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            line = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];
            }
        }

        string command = Console.ReadLine();

        while (command != "cease fire!")
        {
            string[] splt = command.Split();
            int rw = int.Parse(splt[0]);
            int cl = int.Parse(splt[1]);
            int pwr = char.Parse(splt[2]);
            ExecuteTask(matrix, rw, cl, pwr);
            
            command = Console.ReadLine();
        }

        int count = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               // Console.Write("{0} ", matrix[row, col]);
                if (matrix[row,col] <= 0)
                {
                    
                    count++;
                }
                
            }
           // Console.WriteLine();
        }
        double result = (count/(double)(len[0]*len[1]))* 100;
        Console.WriteLine("Destroyed bunkers: {0}\nDamage done: {1:f1} % ", count, result);
    }

    private static void ExecuteTask(int[,] matrix, int rw, int cl, int pwr)
    {
        matrix[rw, cl] -= pwr;
        int halfpwr = (int)Math.Ceiling(pwr/2.0);
        if (true)
        {
            if (rw - 1 >= 0 && cl - 1 >= 0)
            {
                matrix[rw - 1, cl - 1] -= halfpwr;
            }
            if (rw - 1 >= 0)
            {
                matrix[rw - 1, cl] -= halfpwr;
            }
            if (rw -1 >= 0 && cl + 1 <matrix.GetLength(1))
            {
                matrix[rw - 1, cl + 1] -= halfpwr;
            }
            if (cl - 1 >= 0)
            {
                matrix[rw, cl - 1] -= halfpwr;
            }
            if (cl + 1 < matrix.GetLength(1))
            {
                matrix[rw, cl + 1] -= halfpwr;
            }
            if (rw + 1 < matrix.GetLength(0) && cl - 1 >= 0)
            {
                matrix[rw + 1, cl - 1] -= halfpwr;
            }
            if (rw + 1 < matrix.GetLength(0))
            {
                matrix[rw + 1, cl] -= halfpwr;
            }
            if (rw + 1 < matrix.GetLength(0) && cl + 1 < matrix.GetLength(1))
            {
                matrix[rw + 1, cl + 1] -= halfpwr;
            }
            
        }
    }
}


