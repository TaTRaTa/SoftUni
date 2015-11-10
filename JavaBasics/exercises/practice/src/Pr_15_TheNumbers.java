import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo on 9.11.2015 ã..
 */
public class Pr_15_TheNumbers {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        String input = scn.nextLine();
        List<Integer> list = new ArrayList<>();
        List<String> hexList = new ArrayList<>();
        Pattern pat = Pattern.compile("(\\d+)");
        Matcher match = pat.matcher(input);
        while (match.find()){
            list.add(Integer.parseInt(match.group(1)));
        }
        for (int i = 0; i < list.size(); i++) {
            String hex = Integer.toHexString(list.get(i)).toUpperCase();
            hexList.add(hex);
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hexList.size(); i++) {
            int temp = 4 - hexList.get(i).length();
            sb.append("0x");
            for (int j = 0; j < temp; j++) {
                sb.append("0");
            }
            sb.append(hexList.get(i));
            if (hexList.size() - 1 != i){
                sb.append("-");
            }

        }
        System.out.println(sb.toString());

    }
}
