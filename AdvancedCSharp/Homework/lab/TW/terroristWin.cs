using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class terroristWin
{
    private static int CalcBombPower(string bomb)
    {
        int power = 0;
        for (int i = 1; i < bomb.Length - 1; i++)
            power += (int)bomb[i];
        return power % 10;
    }

    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder textBuilder = new StringBuilder(text);
        string bombPattern = @"\|.+?\|";
        foreach (Match match in Regex.Matches(text, bombPattern))
        {
            string bomb = match.Value;
            int bombStart = match.Index;
            int bombLen = match.Length;
            int bombPower = CalcBombPower(bomb);

            int damageStart = 0;
            if ((bombStart - bombPower) > 0)
            {
                damageStart = bombStart - bombPower;
            }

            int damageEnd = bombStart + bombLen;
            if (damageEnd + bombPower < text.Length)
            {
                damageEnd += bombPower;
            }
            else
                damageEnd = text.Length - 1;
            string damagedText = text.Substring(damageStart, damageEnd - damageStart);
            string damage = new string('.', damageEnd - damageStart);
            textBuilder.Replace(damagedText, damage);
        }
        Console.WriteLine(textBuilder);
    }
}

