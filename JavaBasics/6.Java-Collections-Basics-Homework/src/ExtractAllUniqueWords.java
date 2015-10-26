import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeSet;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        TreeSet<String> unique = new TreeSet<String>();

        for (int i = 0; i < text.length; i++) {
            unique.add(text[i].toLowerCase());
        }
        System.out.println(unique);
    }
}
