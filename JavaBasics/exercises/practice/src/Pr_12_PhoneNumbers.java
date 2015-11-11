import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo on 11.11.2015 ã..
 */
public class Pr_12_PhoneNumbers {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        boolean isTrue = true;
        List<String> name = new ArrayList<>();
        List<String> phone = new ArrayList<>();

        String input = scn.nextLine();
        while (!input.equals("END")){
            sb.append(input);
            sb.append("\n");
            input = scn.nextLine();
        }

        Pattern pat = Pattern.compile("([A-Z][a-zA-Z]*)[^\\d\\+a-zA-Z]*(\\+*\\d[0-9\\/\\-()\\s\\.]*\\d)");
        Matcher match = pat.matcher(sb.toString());
        while (match.find()){
            String n = match.group(1).trim();
            String p = match.group(2).trim();
            p = p.replaceAll("[()\\/\\.\\-\\s]", "");
            name.add(n);
            phone.add(p);
        }
        for (int i = 0; i < name.size(); i++) {

            if (i == 0){
                System.out.printf("<ol><li><b>%s:</b> %s</li>", name.get(i), phone.get(i));
                isTrue = false;
                if (name.size() == 1){
                    System.out.printf("</ol>");
                }
                continue;

            }
            if (i == name.size() - 1){
                System.out.printf("<li><b>%s:</b> %s</li></ol>", name.get(i), phone.get(i));
                return;
            }
            System.out.printf("<li><b>%s:</b> %s</li>", name.get(i), phone.get(i));

        }
        if (isTrue){
            System.out.println("<p>No matches!</p>");
        }



    }
}
