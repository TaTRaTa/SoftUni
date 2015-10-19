package com.company;

import java.math.BigDecimal;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String[] A = Console.nextLine().split(" ");
        String[] B = Console.nextLine().split(" ");
        String[] C = Console.nextLine().split(" ");
        int Ax = Integer.parseInt(A[0]);
        int Ay = Integer.parseInt(A[1]);
        int Bx = Integer.parseInt(B[0]);
        int By = Integer.parseInt(B[1]);
        int Cx = Integer.parseInt(C[0]);
        int Cy = Integer.parseInt(C[1]);

        int area = Math.abs(((Ax * (By - Cy)) + (Bx * (Cy - Ay)) + (Cx * (Ay - By))) / 2);

        System.out.println(area);
    }
}
