package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");

        int first = Integer.parseInt(line[0]);
        String hex = Integer.toHexString(first);
        String bin = Integer.toBinaryString(first);
        first = Integer.parseInt(bin);
        double second = Double.parseDouble(line[1]);
        double third = Double.parseDouble(line[2]);


        System.out.printf("|%-10s|%010d|%10.2f|%-10.3f| ", hex,first, second, third);
    }
}
