import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 �..
 */
public class CountAllWords {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        System.out.println(text.length);
    }
}
