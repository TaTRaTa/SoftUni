import java.util.Scanner;

/**
 * Created by lenovo on 22.10.2015 ã..
 */
public class SequencesOfEqualStrings {
    public static void main(String[] args) {

        Scanner scr = new Scanner(System.in);
        String[] line = scr.nextLine().split(" ");
        for (int i = 0; i < line.length - 1; i++) {

            if (line[i].equals(line[i + 1])){
                System.out.print(line[i] + " ");
            }
            else {
                System.out.println(line[i]);
            }
        }
        System.out.print(line[line.length - 1]);
}
}
