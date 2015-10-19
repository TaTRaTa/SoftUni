package com.company;

import com.sun.org.apache.xalan.internal.xsltc.util.IntegerArray;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        String[] nums = console.nextLine().split(" ");
        String[] get = console.nextLine().split(" ");
        int digit = Integer.parseInt(get[1].trim());
        String argument = get[2].toLowerCase();
        int[] arr = new int[nums.length];
        for (int i = 0; i < nums.length; i++) {
            arr[i] = Integer.parseInt(nums[i]);
        }

        executeAlgo(arr, digit, argument);
    }


    static void executeAlgo(int[] arr, int digit, String argument) {
        int count = 0;
        for (int i = 0; i < arr.length; i++) {

            if (argument.equals("odd") && arr[i] % 2 != 0) {
                if (count < digit) {
                    System.out.print(arr[i] + " ");

                }

            } else if (argument.equals("even") && arr[i] % 2 == 0) {
                if (count < digit) {
                    System.out.print(arr[i] + " ");

                }
            }
        }

    }
}
