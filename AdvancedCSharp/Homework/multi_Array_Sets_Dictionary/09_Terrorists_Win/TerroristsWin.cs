using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder text = new StringBuilder(input);
        string pattern = @"\|.+?\|";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        
        foreach (Match match in matches)
        {
            string bombValue = match.Value;
            int startBomb = match.Index;
            int bombLen = match.Length;
            int bombPower = ExecuteBomb(bombValue);
            // 0<= (startBomb - bombPower) && input.Lenght >=(startBomb + bombLen + bombPower)
            int damageStart = 0;
            if (0 <= (startBomb - bombPower))
            {
                damageStart = startBomb - bombPower;
            }
            
            int damegeEnd = input.Length - 1;
            if (input.Length >= (startBomb + bombLen + bombPower))
            {
                damegeEnd = startBomb + bombLen + bombPower;
            }
            string textRange = input.Substring(damageStart, damegeEnd - damageStart);
            string damage = new string('.', damegeEnd - damageStart);
            text.Replace(textRange, damage);
            
        };
        Console.WriteLine(text);
    }

    static int ExecuteBomb(string bombStr)
    {
        int bomb = 0;
        for (int i = 1; i < bombStr.Length - 1; i++)
        {
            bomb += (int)bombStr[i];
        }

        return bomb%10;
    }
}

