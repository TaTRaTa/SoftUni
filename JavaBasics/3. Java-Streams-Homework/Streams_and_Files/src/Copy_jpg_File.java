import java.io.*;

/**
 * Created by lenovo on 24.10.2015 ã..
 */
public class Copy_jpg_File {
    public static void main(String[] args) throws IOException {
        FileInputStream in = new FileInputStream("src\\brickleberry.jpg");
        FileOutputStream out = new FileOutputStream("src\\my-copied-picture.jpg");
        try {
            int data = in.read();
            while(data != -1){
                out.write(data);
                data = in.read();
            }


        } finally {
            in.close();
            out.close();
        }

    }
}
