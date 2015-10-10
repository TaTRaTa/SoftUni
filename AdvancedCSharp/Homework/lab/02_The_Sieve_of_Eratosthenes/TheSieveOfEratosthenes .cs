using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheSieveOfEratosthenes 
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        HashSet<int> Primes = new HashSet<int>();
        bool[] bigArr = new bool[N + 1];

        for (int i = 0; i < bigArr.Length; i++)
        {
            bigArr[i] = true;
        }

        for (int i = 2; i <= Math.Sqrt(bigArr.Length); i++)
        {
            if (bigArr[i])
            {

                for (int j = i * i; j < bigArr.Length; j = j + i)
                {
                    bigArr[j] = false; 
                }
            }
        }

        for (int i = 2; i < bigArr.Length; i++)
        {
            if (bigArr[i])
            {
                Primes.Add(i);
            }
        }
        string primes = string.Join(", ", Primes);
        Console.WriteLine(primes);
    }
}

