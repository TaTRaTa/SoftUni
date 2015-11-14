import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo on 14.11.2015 ã..
 */
public class Pr_17_BiggestTableRow {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pattern pat = Pattern.compile("\\s*(<.+?>)\\s*([\\d.-]+)");
        String input = sc.nextLine();
        double sumMax = -10000000.0;
        String store1 = "0";
        String store2 = "0";
        String store3 = "0";
        boolean isTrue = false;
        boolean checkForNoData = true;
        while (!input.equals("</table>")){
            List<String> list = new ArrayList<>();
            double digitSum = 0.0;
            Matcher match = pat.matcher(input);
            for (int i = 0; i < 3; i++) {

                while (match.find()){
                    isTrue = true;
                    String str = match.group(2);
                    if (str.equals("-")){
                        digitSum += 0.0;
                        list.add("-");
                    } else {
                        String digitStr = match.group(2).trim();
                            digitSum += Double.parseDouble(digitStr);
                            list.add(digitStr);
                            checkForNoData = false;
                    }
                }
            }
            if (isTrue){
                if (sumMax < digitSum){
                    sumMax = digitSum;
                    store1 = list.get(0);
                    store2 = list.get(1);
                    store3 = list.get(2);
                }
            }

            input = sc.nextLine();
        }

        String print = "";
        if (sumMax % 1 == 0){
            int temp = (int)sumMax;
            print = "" + temp;
        } else {
            print = "" + sumMax;
        }

        if (checkForNoData){
            System.out.println("no data");
        } else {
            if (store1.equals("-")){
                if (store2.equals("-")){
                    System.out.printf(print +" = "+ store3);
                } else if (store3.equals("-")){
                    System.out.printf(print +" = "+ store2);
                }else {
                    System.out.printf(print +" = "+ store2 +" + "+ store3);
                }
            } else if (store2.equals("-")){
                 if (store3.equals("-")){
                    System.out.printf( print +" = "+ store1);
                }else {
                    System.out.printf(print +" = "+ store1 +" + "+ store3);
                }
            } else if (store3.equals("-")){
                    System.out.printf(print +" = "+ store1 +" + "+ store2);
            } else {
                System.out.printf(print +" = "+ store1 +" + "+ store2 +" + "+ store3);
            }
        }
    }
}
