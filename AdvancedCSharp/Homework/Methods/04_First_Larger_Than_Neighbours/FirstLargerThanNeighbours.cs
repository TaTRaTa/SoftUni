using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceTree = { 1, 1, 1 };

        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceTree));
    }

    private static int GetFirstElementLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargestThenNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }

    static bool IsLargestThenNeighbours(int[] number, int i)
    {
        if (i == 0)
        {
            if (number[0] > number[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (i == number.Length - 1)
        {
            if (number[number.Length - 1] > number[number.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (number[i] > number[i - 1] && number[i] > number[i + 1])
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

