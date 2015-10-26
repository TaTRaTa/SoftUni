import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;



/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class ExtractEmails {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String text = scr.nextLine();
        Pattern pat = Pattern.compile("(\\w+[\\.\\w\\-]*@\\w+[\\.a-z]*\\.[a-z]{2,3}\\b)");
        Matcher matcher = pat.matcher(text);
        while (matcher.find()){
            System.out.println(matcher.group(1));
        }
    }
}
