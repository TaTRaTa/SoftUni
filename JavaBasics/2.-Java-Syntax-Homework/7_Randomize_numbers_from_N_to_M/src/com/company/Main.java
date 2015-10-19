package com.company;

import java.util.*;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String[] input = Console.nextLine().split(" ");
        int N = Integer.parseInt(input[0]);
        int M = Integer.parseInt(input[1]);
        Random random = new Random();
        if (N < M) {
            int min = N;
            int max = M;
            List<Integer> list = new ArrayList<>();
            for (int i = min;i <= max; i++){
                list.add(i);
            }
            Collections.shuffle(list);
            System.out.println(list);
        } else if (N > M){
            int min = M;
            int max = N;
            List<Integer> list = new ArrayList<>();
            for (int i = min;i <= max; i++){
                list.add(i);
            }
            Collections.shuffle(list);
            System.out.println(list);
        } else {
            System.out.println(N);
        }
    }
}
