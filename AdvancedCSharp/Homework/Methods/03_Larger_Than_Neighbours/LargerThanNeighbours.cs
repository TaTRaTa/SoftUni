using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        int[] number = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(IsLargestThenNeighbours(number, i));
        }
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
            if (number.Length - 1 > number.Length - 2)
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

