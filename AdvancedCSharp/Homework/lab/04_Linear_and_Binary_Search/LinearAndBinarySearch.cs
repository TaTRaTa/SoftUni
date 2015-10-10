using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LinearAndBinarySearch
{
    static void Main()
    {
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var element = int.Parse(Console.ReadLine());
        int resultLinear = 0, resultBunary = 0;

        resultLinear = LinearSearch(array, element);
        resultBunary = BinarySearch(array, element);

       // Console.WriteLine(resultLinear);
        Console.WriteLine(resultBunary);
    }
    static int LinearSearch(int[] array, int  element)
    {
        for (int i = 0; i <array.Length; i++)
			{
                if (element == array[i])
                {
                    return i;
                }
			}
        return -1;
    }
    static int BinarySearch(int[] array, int element)
    {              
        int posL = 0;                                 // position on Low
        int posH = array.Length - 1;                  // position on High
        int posM =  ((posL + posH) / 2);              // position on Middle
        int low = array[posL], high = array[posH], middle = array[posM];
       
        while (posL <= posH)
        {
            
            if (element < middle)
                {
                    posH = posM - 1;
                    posM = ((posL + posH) / 2);
                    middle = array[posM];
                    continue;
                }
            else if (element > middle)
	            {
                    posL = posM + 1;
                    posM =  ((posL + posH) / 2);
                    middle = array[posM];
                    continue;
	            }
            else
	            {
                    if (array[posM] == array[posL])
                    {
                        return posL;
                    }
                    return posM;
	            }
            
        }
        return -1;
    }
}

