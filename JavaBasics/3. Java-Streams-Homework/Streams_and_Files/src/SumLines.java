
import java.io.*;

/**
 * Created by lenovo on 22.10.2015 ã..
 */
public class SumLines {
    public static void main(String[] args) throws IOException {

        BufferedReader in = new BufferedReader(new FileReader("src\\lines.txt"));

        String line = in.readLine();
        int sum = 0;

        try {
            while (line != null) {

                for (int i = 0; i < line.length(); i++) {
                    sum += line.charAt(i);
                }
                System.out.println(sum);
                sum = 0;
                line = in.readLine();
            }
        } finally {
            in.close();
        }
    }
}
