package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");
        int a = Integer.parseInt(line[0]);
        int b = Integer.parseInt(line[1]);
        System.out.println((a * b));

    }
}
