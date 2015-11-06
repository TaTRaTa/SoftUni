package JavaFundamentalsRetake;

import java.util.Scanner;
import java.util.regex.*;

/**
 * Created by lenovo on 2.11.2015 ã..
 */
public class Problem_2_WeirdScript {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        StringBuilder text = new StringBuilder();
        char[] ch = {
                'Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y'
        };
        int num = Integer.parseInt(scn.nextLine()) % 52; // <-- number is  round % 52

        String input = scn.nextLine();
        while (!input.equals("End")) {
            text.append(input);
            input = scn.nextLine();
        }
        // key is 2 times ch[element] =>> element is equals to number
        String key = "" + ch[num] + ch[num];
        Pattern pat = Pattern.compile(String.format("%s(.*?)%s",key, key)); // <-- regex
        Matcher  match = pat.matcher(text.toString());
        while (match.find()) {

            System.out.println(match.group(1)); //print
        }
    }
}
