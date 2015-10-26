import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        String search = scr.nextLine();
        int count = 0;

        for (int i = 0; i < text.length; i++) {
            if(text[i].toLowerCase().indexOf(search.toLowerCase()) != -1){
                count++;
            }
        }
        System.out.println(count);
    }
}
