using System;

class FloatOrDouble
{
    static void Main()
    {
        double first = 34.567839023D;
        float second = 12.345f;
        double third = 8923.1234857D;
        float fourth = 3456.091f;

        Console.WriteLine("Which of the following values can be assigned to a variable of type float and which to a variable of type double: " +
        "34.567839023, 12.345, 8923.1234857, 3456.091?... \n");
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
    }
}