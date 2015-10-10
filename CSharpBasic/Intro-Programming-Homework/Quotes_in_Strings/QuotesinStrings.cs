using System;

class QuotesinStrings
{
    static void Main()
    {
        Console.WriteLine("Declare two string variables and assign them with following value: ");
        string var1 = "The \"use\" of quotations causes difficulties.";
        string var2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}",var1);
        Console.WriteLine("{0}",var2);
    }
}