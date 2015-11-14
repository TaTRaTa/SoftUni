import java.util.Scanner;
// complete 87%
/**
 * Created by lenovo on 13.11.2015 ã..
 */
public class Pr_8_TextGravity {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int colCount = Integer.parseInt(sc.nextLine());
        String input = sc.nextLine();
        int rowCount = (int) Math.ceil((input.length() / (colCount + 0.0)));
        char[][] matrix = new char[rowCount][colCount];

        int ch = 0;
        for (int row = 0; row < rowCount; row++) {
            for (int col = 0; col < colCount; col++) {
                if (ch >= input.length()){
                    matrix[row][col] = ' ';
                    ch++;
                }else {

                    matrix[row][col] = input.charAt(ch);
                    ch++;
                }
            }
        }


        for (int row1 = rowCount - 1; row1 >= 0 ; row1--) {
            for (int row = rowCount - 1; row >= 0; row--) {
                for (int col = colCount - 1; col >= 0; col--) {
                    if (matrix[row][col] == ' ') {
                        if (row - 1 >= 0 && matrix[row - 1][col] != ' ') {
                            matrix[row][col] = matrix[row - 1][col];
                            matrix[row - 1][col] = ' ';
                        } else {
                            int checkRow = row - 2;
                            while (checkRow >= 0) {
                                if (matrix[checkRow][col] != ' ') {
                                    matrix[row][col] = matrix[checkRow][col];
                                    matrix[checkRow][col] = ' ';
                                    break;
                                }
                                checkRow--;
                            }
                        }
                    }

                }
            }
        }
      //  for (int i = 0; i < rowCount; i++) {
      //      for (int j = 0; j < colCount; j++) {
      //          System.out.print(matrix[i][j]);
      //      }
      //      System.out.println();
      //  }

        for (int row = 0; row < rowCount; row++) {
            if (row == 0){
                System.out.printf("<table>");
            }
            System.out.printf("<tr>");
            for (int col = 0; col < colCount; col++) {
                if (matrix[row][col]== '<'){
                    System.out.printf("<td>&lt;</td>");
                } else if (matrix[row][col] == '>'){
                    System.out.printf("<td>&gt;</td>");
                } else if (matrix[row][col] == '"'){
                    System.out.printf("<td>&quot;</td>");
                }else {
                    System.out.printf("<td>%s</td>", "" + matrix[row][col]);
                }

            }
            System.out.printf("</tr>");
            if (row == rowCount - 1){
                System.out.printf("</table>");
            }
        }
    }
}

