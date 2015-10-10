using System;

class DecryptTheMessages
{
    static void Main()
    {
        string command = Console.ReadLine();


        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }
            
        command = Console.ReadLine();
        char[] symbols;
        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }
             symbols = command.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                char currentSymbol = symbols[i];
                switch (symbols[i])
                {
                    case '+': symbols[i] = ' '; break;
                    case '%': symbols[i] = ','; break;
                    case '&': symbols[i] = '.'; break;
                    case '#': symbols[i] = '?'; break;
                    case '$': symbols[i] = '!'; break;
                    default: if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                        {
                            symbols[i] = (char)(currentSymbol + 13);
                        }
                        else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                        {
                            symbols[i] = (char)(currentSymbol - 13);
                        }
                        break;
                }
            }
            Array.Reverse(symbols);

        }
        Console.WriteLine(symbols);
    }
}