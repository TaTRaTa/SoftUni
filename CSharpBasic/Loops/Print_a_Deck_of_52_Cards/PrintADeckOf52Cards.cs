using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            for (int j = 5; j < 7; j--)
            {
                if (i < 11)
                {
                    Console.Write("{0,2}{1} ", i, (char)j);
                }
                switch (i)
                {
                    case 11: Console.Write(" J{0,-2}", (char)j);
                        break;
                    case 12: Console.Write(" Q{0,-2}", (char)j);
                        break;
                    case 13: Console.Write(" K{0,-2}", (char)j);
                        break;
                    case 14: Console.Write(" A{0,-2}", (char)j);
                        break;
                }
                if (j == 3)
                {
                    j = 7;
                }
                if (j == 6)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        //int spatiq = 5;
        //int karo = 4;
        //int kupa = 3;
        //int pika = 6;

        //for (int i = 2; i < 15; i++)
        //{
        //    switch (i)
        //    {
        //        default:
        //            Console.Write("{0,2}{1} ",i,(char)spatiq);
        //            Console.Write("{0,2}{1} ",i,(char)karo);
        //            Console.Write("{0,2}{1} ",i,(char)kupa);
        //            Console.WriteLine("{0,2}{1}",i,(char)pika);
        //            break;
        //        case 11:
        //            Console.Write(" J{0,-2}",(char)spatiq);
        //            Console.Write(" J{0,-2}",(char)karo);
        //            Console.Write(" J{0,-2}",(char)kupa);
        //            Console.WriteLine(" J{0,-2}",(char)pika);
        //            break;
        //        case 12:
        //            Console.Write(" Q{0,-2}", (char)spatiq);
        //            Console.Write(" Q{0,-2}", (char)karo);
        //            Console.Write(" Q{0,-2}", (char)kupa);
        //            Console.WriteLine(" Q{0,-2}", (char)pika);
        //            break;
        //        case 13:
        //            Console.Write(" K{0,-2}", (char)spatiq);
        //            Console.Write(" K{0,-2}", (char)karo);
        //            Console.Write(" K{0,-2}", (char)kupa);
        //            Console.WriteLine(" K{0,-2}", (char)pika);
        //            break;
        //        case 14:
        //            Console.Write( " A{0,-2}", (char)spatiq);
        //            Console.Write( " A{0,-2}", (char)karo);
        //            Console.Write( " A{0,-2}", (char)kupa);
        //            Console.WriteLine(" A{0,-2}", (char)pika);
        //            break;

                
        //    }
        //}
        
    }
}