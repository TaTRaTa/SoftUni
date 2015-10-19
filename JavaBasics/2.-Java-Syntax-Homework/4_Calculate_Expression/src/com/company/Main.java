package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);

        String[] line = Console.nextLine().split(" ");
        double a = Double.parseDouble(line[0]);
        double b = Double.parseDouble(line[1]);
        double c = Double.parseDouble(line[2]);


        double F1 = Math.pow(((Math.pow(a,2) + Math.pow(b,2))/(Math.pow(a,2) - Math.pow(b,2))),((a + b + c)/Math.sqrt(c)));
        double F2 = Math.pow((Math.pow(a,2) + Math.pow(b,2) - Math.pow(c,3)),(a - b));
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f |", F1, F2, Math.abs((((a + b + c) / 3) - ((F1 + F2) / 2))));

    }
}
