using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeFactorization
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int n = num;
        int primeNum = 2;
        List<int> listPrimesNum = new List<int>();

        while (n != 1)
	    {
	         if (n % primeNum == 0)
	            {
		            n /= primeNum;
                    listPrimesNum.Add(primeNum);
	            }
            else
	            {
                    primeNum++;
	            }
	    }

            Console.Write(num + " = ");
            Console.WriteLine(string.Join(" * ", listPrimesNum));
    }
}

