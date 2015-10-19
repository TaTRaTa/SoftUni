package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String input = Console.nextLine().trim();
        int len = input.length() - 1;
        int sum = 0;
        for (int i = 0;i < input.length(); i++, len-- ){
            sum += ( Integer.parseInt(""+input.charAt(i)))* Math.pow(7,len);
        }
        System.out.println(sum);

    }
}
