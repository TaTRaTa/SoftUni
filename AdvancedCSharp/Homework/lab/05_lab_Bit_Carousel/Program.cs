namespace Debugging_BitCarousel
{
    using System;
    // have a problem
    class BitCarousel_broken
    {
        static void Main()
        {
            byte number = byte.Parse(Console.ReadLine());
            byte rotations = byte.Parse(Console.ReadLine());
            const int cell = 6;
            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << cell);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> cell) & 1;
                    number <<= 1;
                    number |= (byte)leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}
