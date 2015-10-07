using System;
using System.Linq;
using System.Numerics;


class Program
{
    static void Main()
    {
        BigInteger[] input = Console.ReadLine().Split(new char []{}, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

        string command = Console.ReadLine();
        int currentIndex = 0;
        while (command != "stop")
        {
            string[] commandParams = command.Split();
            int offset = int.Parse(commandParams[0]) % input.Length;
            char operation = char.Parse(commandParams[1]);
            int operand = int.Parse(commandParams[2]);

            if (offset < 0)
            {
                offset += input.Length;
            }

            currentIndex = (currentIndex + offset) % input.Length;

            ExecuteOperation( input, currentIndex, operation, operand);

            command = Console.ReadLine();
        }

        Console.Write("[");
        Console.Write(string.Join(", ", input));
        Console.WriteLine("]");

    }

    private static void ExecuteOperation(BigInteger[] input, int currentIndex, char operation, int operand)
    {
        
        switch (operation)  
        {
           
            case '&':
               input[currentIndex] &= operand;
        break;
            case '|':
                input[currentIndex] |= operand;
                break;
            case '^':
                input[currentIndex] ^= operand;
                break;
            case '+':
                input[currentIndex] += operand;
                break;
            case '-':
                input[currentIndex] -= operand;
                break;
             case '*':
                input[currentIndex] *= operand;
                break;
            case '/':
                input[currentIndex] /= operand;
                break;
        }
        if (input[currentIndex] < 0)
        {
            input[currentIndex] = 0;
        }
    }
}

