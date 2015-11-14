import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by lenovo on 13.11.2015 ã..
 */
public class Pr_10_ClearingCommands {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = 0;
        List<String[]> list = new ArrayList<>();
        String input = sc.nextLine();
        while (!input.equals("END")){
            N++;
            list.add(input.split(""));
            input = sc.nextLine();
        }
        List<String[]> clList = new ArrayList<>();
        for (int i = 0; i < list.size(); i++) {
            String[] arr = new String[list.get(i).length];
            for (int j = 0; j < list.get(i).length; j++) {
                arr[j] = list.get(i)[j];
            }
            clList.add(arr);
        }
        for (int row = 0; row < list.size(); row++) {
            for (int col = 0; col < list.get(row).length; col++) {
                int currentcol = 0;
                switch (list.get(row)[col]){
                    case ">":
                        clList.get(row)[col] = "&gt;";
                         currentcol = col + 1;
                        while (true){
                            if (currentcol >= list.get(row).length ||
                                    (list.get(row)[currentcol].equals("<") ||
                                    list.get(row)[currentcol].equals("v") ||
                                    list.get(row)[currentcol].equals("^") ||
                                    list.get(row)[currentcol].equals(">"))){
                                break;
                            }
                            clList.get(row)[currentcol] = " ";
                            currentcol++;
                        }
                        break;
                    case "<":
                        clList.get(row)[col] = "&lt;";
                         currentcol = col - 1;
                        while (true){
                            if (currentcol < 0 ||
                                    (list.get(row)[currentcol].equals("<") ||
                                    list.get(row)[currentcol].equals("v") ||
                                    list.get(row)[currentcol].equals("^") ||
                                    list.get(row)[currentcol].equals(">"))){
                                break;
                            }
                            clList.get(row)[currentcol] = " ";
                            currentcol--;
                        }

                        break;
                    case "v":

                        currentcol = row + 1;
                        while (true){
                            if (currentcol >= list.size() ||
                                    (list.get(currentcol)[col].equals("<") ||
                                            list.get(currentcol)[col].equals("v") ||
                                            list.get(currentcol)[col].equals("^") ||
                                            list.get(currentcol)[col].equals(">"))){
                                break;
                            }
                            clList.get(currentcol)[col] = " ";
                            currentcol++;
                        }

                        break;
                    case "^":
                        currentcol = row - 1;
                        while (true){
                            if (currentcol < 0 ||
                                    (list.get(currentcol)[col].equals("<") ||
                                            list.get(currentcol)[col].equals("v") ||
                                            list.get(currentcol)[col].equals("^") ||
                                            list.get(currentcol)[col].equals(">"))){
                                break;
                            }
                            clList.get(currentcol)[col] = " ";
                            currentcol--;
                        }
                        break;

                }
            }

        }
        for (int i = 0; i < clList.size(); i++) {
            System.out.printf("<p>");
            for (int j = 0; j < clList.get(i).length; j++) {
                System.out.print(clList.get(i)[j]);
            }
            System.out.println("</p>");
        }
    }
}
