using System;

class InstructionSet_broken
{
    static void Main()
    {

        string opCode = Console.ReadLine();

        while (opCode.ToUpper() != "END")
        {
                string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = (long)operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = (long)operandOne - 1;
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            opCode = Console.ReadLine();
        }
    }
}