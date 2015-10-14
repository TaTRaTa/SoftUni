package com.company;

import com.sun.xml.internal.bind.v2.runtime.RuntimeUtil;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Scanner Console = new Scanner(System.in);
        int input = Integer.parseInt(Console.nextLine());
        for (int j = 0; j < input; j ++) {
            for (int i = 0 ; i <= j; i++) {
                    System.out.print((char)(i + 97));
            }
            System.out.println();
        }
        for (int j = input - 2; j >=0; j --) {
            for (int i = 0 ; i <= j; i++) {
                System.out.print((char)(i + 97));
            }
            System.out.println();
        }
    }
}
