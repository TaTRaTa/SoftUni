import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by lenovo on 28.10.2015 ã..
 */
public class pr_1_RemovePlus {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);

        String input = scr.nextLine();
        List<char[]> list  = new ArrayList<>();
        List<char[]> checklist  = new ArrayList<>();

        while (!input.toUpperCase().equals("END")) {
            char[] ch = input.toCharArray();
            list.add(ch);
            //checklist.add(ch);
            input = scr.nextLine();

        }
        for (int i = 0; i < list.size(); i++) {
            char[] chs = new char[list.get(i).length];

            for (int j = 0; j < list.get(i).length; j++) {
                chs[j] = list.get(i)[j];
            }
            checklist.add(chs);
        }


        for (int i = 1; i < checklist.size() - 1; i++) {
            for (int j = 1; j < checklist.get(i).length; j++) {
                if (isTrue(checklist,i,j)) {
                    list.get(i)[j] = '\0';
                    list.get(i - 1)[j] = '\0';
                    list.get(i + 1)[j] = '\0';
                    list.get(i)[j - 1] = '\0';
                    list.get(i)[j + 1] = '\0';

                }
            }
        }
        for (char[] chars : list) {
            for (char c : chars) {
                if (c == '\0') {
                    // nothing
                }
                else {
                    System.out.print(c);
                }
            }
            System.out.println();
        }

    }
    static boolean isTrue (List<char[]> checklist, int i, int j) {

        if (((0 <= i - 1 && 0 <= j - 1) && (j< checklist.get(i - 1).length && j< checklist.get(i + 1).length) &&
                (i + 1 < checklist.size() && j + 1 < checklist.get(i).length))){
            char x = Character.toUpperCase(checklist.get(i)[j]);
            char up = Character.toUpperCase(checklist.get(i - 1)[j]);
            char down = Character.toUpperCase(checklist.get(i + 1)[j]);
            char left = Character.toUpperCase(checklist.get(i)[j - 1]);
            char right = Character.toUpperCase(checklist.get(i)[j + 1]);

            if (x == up &&
                    x == down &&
                    x == left &&
                    x == right){
                return true;
            }
            return false;
        }
            return false;
    }
}
