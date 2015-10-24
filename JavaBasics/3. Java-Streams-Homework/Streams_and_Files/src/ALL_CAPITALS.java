import java.io.*;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by lenovo on 24.10.2015 ã..
 */
public class ALL_CAPITALS {
    public static void main(String[] args) throws IOException {

        BufferedReader in = new BufferedReader(new FileReader("src\\text_capitals.txt"));
        FileWriter fw = new FileWriter("src\\text_capitals.txt", true);
        PrintWriter print = new PrintWriter(fw, true);

        try {

            String line = in.readLine();
            List<String> list = new ArrayList<>();
            while (line != null){
                list.add(line);
                line = in.readLine();
            }
            for (String s : list) {
                print.println(s.toUpperCase());
            }
            print.println();


        }finally {
            in.close();
            fw.close();
            print.close();
        }


    }
}
