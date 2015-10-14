package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	 String[] arg = {
             "Gee",
             "Bro",
             "Zuz",
             "Ma",
             "Duh",
             "Yo",
             "Dis",
             "Hood",
             "Jam",
             "Mack"
     };
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        for (int i = 0; i < input.length(); i++) {
            System.out.print(arg[input.charAt(i) - '0']);
        }
    }
}
