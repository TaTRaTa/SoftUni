package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double a = Double.parseDouble(console.nextLine());
        double b = Double.parseDouble(console.nextLine());
        double c = Double.parseDouble(console.nextLine());

        double result = Average(a,b,c);
        System.out.printf("%.2f", result);

    }
    public static double Average(double a, double b,double c ){

        return (a + b + c)/3.0;
    }
}

