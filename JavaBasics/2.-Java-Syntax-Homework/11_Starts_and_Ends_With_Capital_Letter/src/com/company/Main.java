package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {

        Scanner scn = new Scanner(System.in);
        String line = scn.nextLine();
        Pattern pat = Pattern.compile("(\\b[A-Z][A-Za-z]*[A-Z]\\b)");
        Matcher match = pat.matcher(line);
        while (match.find()){
            System.out.print(match.group() + " ");
        }
    }
}
