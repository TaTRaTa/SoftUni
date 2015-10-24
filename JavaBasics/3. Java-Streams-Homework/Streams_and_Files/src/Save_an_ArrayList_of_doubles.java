import javax.tools.FileObject;
import java.io.*;
import java.util.ArrayList;

/**
 * Created by lenovo on 24.10.2015 ã..
 */
public class Save_an_ArrayList_of_doubles {
    public static void main(String[] args) throws IOException {

        ObjectOutputStream output = new ObjectOutputStream(new FileOutputStream("src\\doubles.list"));
        ArrayList<Double> doubles = new ArrayList<>();
        // below lines append values
        doubles.add(723.23);
        doubles.add(623.42);
        doubles.add(323.62);
        doubles.add(153.01);
        doubles.add(14.234);
        doubles.add(123.23);
        doubles.add(4323.5);
        doubles.add(143.21);
        output.writeObject(doubles);
        output.flush();

        // below lines check what i have in my object
        ObjectInputStream input = new ObjectInputStream(new FileInputStream("src\\doubles.list"));
        for (Double aDouble : doubles) {
            System.out.println(aDouble);
        }
        input.close();

    }
}
