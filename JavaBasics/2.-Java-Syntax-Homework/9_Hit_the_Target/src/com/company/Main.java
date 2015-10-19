package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        int target = Integer.parseInt(input);

        for (int D1 = 1; D1 <= 20; D1++) {
            for (int D2 = 1; D2 <= 20; D2++) {
                if (D1 + D2 == target){
                    System.out.printf("%d + %d = %d\n", D1, D2, target);
                }
                if (D1 - D2 == target){
                    System.out.printf("%d - %d = %d\n", D1, D2, target);
                }
            }
        }
    }
}
