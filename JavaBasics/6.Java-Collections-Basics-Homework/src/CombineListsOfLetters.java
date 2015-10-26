import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        ArrayList<Character> list = new ArrayList<Character>();
        String oneLine = scr.nextLine().replaceAll(" ","");
        String twoLine = scr.nextLine().replaceAll(" ","");
        for (int i = 0; i < oneLine.length(); i++) {
            list.add(oneLine.charAt(i));
        }
        for (int i = 0; i < twoLine.length(); i++) {

            if (!list.contains(twoLine.charAt(i))){
                list.add(twoLine.charAt(i));
            }
        }
        for (int i = 0; i < list.size(); i++) {
            System.out.print(list.get(i) + " ");
        }
        System.out.println();
    }
}
