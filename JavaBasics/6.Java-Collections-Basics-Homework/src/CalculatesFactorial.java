import java.util.Scanner;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class CalculatesFactorial {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        int num = Integer.parseInt(scr.nextLine());
        int result = factorial(num);
        System.out.println(result);
    }

    private static int factorial(int num) {
        if (num == 0){
            return 1;
        }
        else {
            return num * factorial(num - 1);
        }
    }


}
