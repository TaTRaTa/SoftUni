import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class LargestSequenceOfEqualStrings {

    public static void main(String[] args) {

        Scanner scr = new Scanner(System.in);

        String[] input = scr.nextLine().split(" ");
        String word = new String();
        int maxSeq = Integer.MIN_VALUE;
        int cout = 1;
        for (int i = 0; i < input.length - 1; i++) {
            if (input[i].equals(input[i + 1])) {
                 cout++ ;
                if (i == input.length - 2) {
                    if (maxSeq < cout) {
                        word = input[i];
                        maxSeq = cout;
                    }

                }
            }
            else {
                if (maxSeq < cout) {
                    word = input[i];
                    maxSeq = cout;
                }
                cout = 1;
            }
        }
        for (int i = 0; i < maxSeq; i++) {
            System.out.print(word + " ");
        }
        System.out.println();
    }
}
