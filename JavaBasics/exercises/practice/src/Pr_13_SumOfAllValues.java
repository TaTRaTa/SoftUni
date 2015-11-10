import java.util.Scanner;
import java.util.regex.*;


/**
 * Created by lenovo on 9.11.2015 ã..
 */
public class Pr_13_SumOfAllValues {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        String keysString = scn.nextLine();
        String textString = scn.nextLine();
        Pattern pat = Pattern.compile("^([A-Za-z_]+)\\d.*\\d([a-zA-Z_]+)$");
        Matcher match = pat.matcher(keysString);
        String startKey = "";
        String endkey = "";
        while (match.find()){

             startKey = match.group(1);
             endkey = match.group(2);

        }
        if (startKey.equals("") || endkey.equals("")){
            System.out.println("<p>A key is missing</p>");
            return;
        }
        Pattern pattern = Pattern.compile(String.format("%s(\\.*\\d+\\.*\\d*)%s", startKey, endkey));
        Matcher match1 = pattern.matcher(textString);
        double sum = 0.0;
        while (match1.find()){
            sum += Double.parseDouble(match1.group(1));

        }

        if (sum == 0.0){
            System.out.println("<p>The total value is: <em>nothing</em></p>");
        } else if ( sum % 1 == 0 ){
            System.out.println("<p>The total value is: <em>"+ Math.round(sum) +"</em></p>");
        } else {
            System.out.printf("<p>The total value is: <em>%.2f</em></p>", sum);
        }




    }
}
