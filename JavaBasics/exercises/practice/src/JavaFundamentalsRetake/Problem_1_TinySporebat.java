package JavaFundamentalsRetake;

import java.util.Scanner;

/**
 * Created by lenovo on 31.10.2015 ã..
 */
public class Problem_1_TinySporebat {
    public static void main(String[] args) {
        int myHealth = 5800;
        int Glowcaps = 0;
        final int  cost = 30;
        Scanner scn = new Scanner(System.in);
        String input = scn.nextLine();
        while (!input.equals("Sporeggar")){

            for (int i = 0; i < input.length() - 1; i++) {
                if (input.charAt(i) == 'L'){
                    myHealth += 200;              // add health
                } else {
                    myHealth -= input.charAt(i);  // execute damage
                }
            }
            if (myHealth <= 0) {
                break;
            }

            Glowcaps += Integer.parseInt(input.substring(input.length() - 1)); // here sum Glowcaps
            input = scn.nextLine();
        }
        // the below lines print result by conditions
        if (input.equals("Sporeggar")) {
            System.out.printf("Health left: %d\n",myHealth);
            int result = Glowcaps - cost;
            if ((result)>= 0 ) {
                System.out.printf("Bought the sporebat. Glowcaps left: %d", result);
            } else {
                System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.",(int)Math.abs((double)result));
            }

        } else {
            System.out.printf("Died. Glowcaps: %d",Glowcaps);
        }
    }
}
