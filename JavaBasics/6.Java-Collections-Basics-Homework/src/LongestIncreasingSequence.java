import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class LongestIncreasingSequence {
    public static void main(String[] args) {

        Scanner scr = new Scanner(System.in);
        int[] nums = Arrays.asList(scr.nextLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
        int longestSeq = 1;
        int currnet = 1;
        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] < nums[i + 1]) {
                currnet++;
                System.out.print(nums[i] + " ");
            }
            else {
                System.out.println(nums[i]);
                if (longestSeq < currnet) {
                    longestSeq = currnet;
                }
                currnet = 1;
            }
        }
        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] < nums[i + 1]) {
                currnet++;
            }
            else {
                if (longestSeq == currnet){
                    System.out.print("Longest: ");
                    for(int j = i - longestSeq + 1; j <= i; j++) {
                        System.out.print(nums[j] + " ");
                    }
                    break;
                }
                currnet = 1;
            }
        }

    }
}
