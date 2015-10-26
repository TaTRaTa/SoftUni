import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by lenovo on 22.10.2015 ã..
 */
public class SortArrayOfNumbers {

    public static void main(String[] args) {

        Scanner scr = new Scanner(System.in);
        int n = Integer.parseInt(scr.nextLine());
        String str = scr.nextLine().replaceAll(" ","");
        int[] arr = new int[n];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = Integer.parseInt("" + str.charAt(i));
        }

        int maxValue = Integer.MIN_VALUE;
        for (int i = 0; i < arr.length - 1; i++) {
            for (int j = 0; j < arr.length - 1; j++) {
                if (arr[j] > arr[j + 1]){
                    maxValue = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = maxValue;

                }
            }
        }

        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
    }
}
