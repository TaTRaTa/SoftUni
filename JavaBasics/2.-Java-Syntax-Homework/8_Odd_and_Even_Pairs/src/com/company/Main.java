package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        if (input.length % 2 == 0){

            for (int i = 0; i < input.length; i+=2) {
                int firstDigit = Integer.parseInt(input[i]);
                int secondDigit = Integer.parseInt(input[i + 1]);
                if (firstDigit % 2 == 0 && secondDigit % 2 == 0) {
                    System.out.printf("%d, %d -> both are even \n", firstDigit,secondDigit);
                } else if (firstDigit % 2 != 0 && secondDigit % 2 != 0){
                    System.out.printf("%d, %d -> both are odd\n", firstDigit, secondDigit);
                } else {
                    System.out.printf("%d, %d -> different\n", firstDigit, secondDigit);
                }
            }

        } else {
            System.out.println("Invalid length");

        }

    }
}
