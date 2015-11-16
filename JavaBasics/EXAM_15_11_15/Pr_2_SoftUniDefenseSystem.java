package EXAM;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo on 15.11.2015 ã..
 */
public class Pr_2_SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pattern pat = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?(\\d+)L");
        StringBuilder sb = new StringBuilder();
        int sum = 0;
        String input = sc.nextLine();
        while (!input.equals("OK KoftiShans")){
            Matcher match = pat.matcher(input);
            while (match.find()){
               sum += Integer.parseInt(match.group(3));
               sb.append(String.format("%s brought %s liters of %s!", match.group(1), match.group(3), match.group(2).toLowerCase()));
               sb.append("\n");
            }

            input = sc.nextLine();
        }
        double quantity = 0.0;
        quantity = (sum / 1000.0);
        System.out.print(sb.toString());
        System.out.printf("%.3f softuni liters",quantity);

    }
}
