using System;

class Sunglasses
{
    static void Main()
    {
       
        Console.WriteLine(" Write ODD Number.. ");
        int n = int.Parse(Console.ReadLine());

        string frames = new string('*', n * 2);
        string space = new string(' ', n);
        printFrame(frames, space);
        Console.WriteLine();

        string lenses = new string('/', (n * 2) - 2);
        string bridge = new string('|', n);
        for (int i = 0; i < n - 2; i++)
        {
            PrintLens(lenses);
            if (((n - 1) / 2) == i + 1)
            {
                Console.Write(bridge);
            }
            else
            {
                Console.Write(space);
            }
            PrintLens(lenses);
            Console.WriteLine();
        }
        printFrame(frames, space);
        Console.WriteLine();
    }


    private static void printFrame(string frames, string space)
    {
        Console.Write(frames);
        Console.Write(space);
        Console.Write(frames);
    }
    private static void PrintLens(string lenses)
    {
        Console.Write('*');
        Console.Write(lenses);
        Console.Write('*');
    }
}

    
