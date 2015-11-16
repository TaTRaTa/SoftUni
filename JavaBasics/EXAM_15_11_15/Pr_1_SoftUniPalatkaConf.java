package EXAM;

import java.util.Scanner;

/**
 * Created by lenovo on 15.11.2015 ã..
 */
public class Pr_1_SoftUniPalatkaConf {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int people = Integer.parseInt(sc.nextLine().trim());
        int lines = Integer.parseInt(sc.nextLine().trim());
        int sum = 0;
        int food = 0;
        for (int i = 0; i < lines; i++) {
            String[] input = sc.nextLine().split(" ");
            String name = input[0];
            int digit = Integer.parseInt(input[1].trim());
            String type = input[2].trim();

            if (name.equals("tents")){
                if (type.equals("firstClass")){
                    sum += digit * 3;
                } else {
                    sum += digit * 2;
                }
            } else if (name.equals("rooms")){
                if (type.equals("single")){
                    sum += digit;
                } else if (type.equals("double")){
                    sum += digit * 2;
                } else if (type.equals("triple")){
                    sum += digit * 3;
                }
            } else if (name.equals("food")){
                if (type.equals("musaka")){
                    food += digit * 2;
                } else if (type.equals("zakuska")){
                    food += 0;
                }
            }

        }
        if (people <= sum){
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", (sum - people));
            if (food >= people){
                System.out.printf("Nobody left hungry. Meals left: %d\n", (food - people));
            } else {
                System.out.printf("People are starving. Meals needed: %d\n", people - food);
            }

        } else {
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", (people - sum));
            if (food >= people){
                System.out.printf("Nobody left hungry. Meals left: %d\n", (food - people));
            } else {
                System.out.printf("People are starving. Meals needed: %d\n", people - food);
            }
        }
    }
}
