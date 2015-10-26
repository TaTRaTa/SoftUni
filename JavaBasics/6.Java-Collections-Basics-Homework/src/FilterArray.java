import java.util.Scanner;

/**
 * Created by lenovo on 26.10.2015 ã..
 */
public class FilterArray {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] input = scr.nextLine().split(" ");
        boolean isTrue = true;
        for (int i = 0; i < input.length; i++) {
            if (input[i].length() > 3){
                System.out.print(input[i] + " ");
                isTrue = false;
            }

        }
        if (isTrue) {
            System.out.println("(empty)");
        }

    }
}
