package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String input = Console.nextLine().trim();
        int num = Integer.parseInt(input);
        List<Integer> base7 = new ArrayList<>();

        while (true){
            if (num == 0){
                break;
            }
            int temp = 0;
            temp = num % 7;
            base7.add(temp);
            num /= 7;
        }
        Collections.reverse(base7);
        for (int i = 0; i < base7.size(); i++) {
            System.out.print(base7.get(i));
        }
    }
}
