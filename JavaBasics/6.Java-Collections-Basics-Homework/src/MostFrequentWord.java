import java.util.*;

/**
 * Created by lenovo on 23.10.2015 ã..
 */
public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        TreeMap<String,Integer> list = new TreeMap<>();

        for (int i = 0; i < text.length; i++) {
            Integer count = list.get(text[i].toLowerCase());
            if (count == null){
                count = 0;
            }
            list.put(text[i].toLowerCase(),count + 1);
        }
        //System.out.println(list);

        for (Map.Entry<String, Integer> stringIntegerEntry : list.entrySet()) {
            int longest = 0;
            if (stringIntegerEntry.getValue() > 1){
                longest = stringIntegerEntry.getValue();
                System.out.printf("%s -> %d\n", stringIntegerEntry.getKey(), longest);
            }

        }






       // TreeMap<String, TreeMap<String, Integer>> data = new TreeMap<>();
//
//
       // for (Map.Entry<String, TreeMap<String, Integer>> iteration : data.entrySet()) {
       //
       //     for (Map.Entry<String, Integer> inneriter : iteration.getValue().entrySet()) {
       //
       //     }
       // }
//
    }
}
