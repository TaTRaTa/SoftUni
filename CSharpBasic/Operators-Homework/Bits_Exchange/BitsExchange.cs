using System;

    class BitsExchange
    {
        static void Main()
        {
          
            uint n = uint.Parse(Console.ReadLine());

            int mask, mask2;

            for (int pos = 3; pos < 6; pos++)
            {
                uint temp = (n >> pos) & 1;
                uint temp2 = (n >> pos + 21) & 1;
                if (temp != temp2)
                {
                    mask = 1 << pos;
                    mask2 = 1 << pos + 21;
                    n = n ^ (uint)mask;
                    n = n ^ (uint)mask2;

                }
            }
            Console.WriteLine(n);
        }
           
    }

