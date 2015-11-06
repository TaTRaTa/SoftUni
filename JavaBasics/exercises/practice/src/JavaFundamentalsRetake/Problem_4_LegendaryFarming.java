package JavaFundamentalsRetake;

import java.util.*;
import java.util.regex.*;

/**
 * Created by lenovo on 2.11.2015 �..
 */
public class Problem_4_LegendaryFarming {
    private static final int maxQuantity = 250; // constant

    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        // The below lines declared three map -> materialsKey, junk, legendary
        Map<String, Integer> materialsKey = new LinkedHashMap<String, Integer>(){{
        put("fragments", 0);
        put("motes", 0);
        put("shards", 0);
        }};
        Map<String, Integer> junk = new TreeMap<>();
        Map<String, String> legendary = new HashMap<String, String>(){{
        put("shards","Shadowmourne");
        put("fragments","Valanyr");
        put("motes","Dragonwrath");
        }};
        // Two reason for String firstWin: 1. To break from while(true) loops AND 2. To search in Collection "legendary"
        String firstWin = "";
        String input = scn.nextLine();
        while (true){
            // The below lines use regex to search data from input
            Pattern pat = Pattern.compile("((\\d+)\\s+([a-zA-Z-_.]+))");
            Matcher match = pat.matcher(input);
            while (match.find()){
                int quantity = Integer.parseInt(match.group(2).trim());
                String materials = match.group(3).toLowerCase().trim(); // by conditions materials should be toLowercase

                if (materialsKey.containsKey(materials)){ // sorted data by maps (materialsKey OR junk)
                    materialsKey.put(materials, materialsKey.get(materials) + quantity);

                    if (materialsKey.get(materials) >= maxQuantity){ // cheack if quantity is bigger or equals on 250 to break
                        materialsKey.put(materials, materialsKey.get(materials) - maxQuantity);
                        firstWin = materials;
                        break;
                    }

                } else {
                    if (!junk.containsKey(materials)){
                        junk.put(materials, 0);
                    }
                    junk.put(materials, junk.get(materials) + quantity);
                }
            }

            if (firstWin.length() > 0){
                break;
            } else {
                input = scn.nextLine();
            }
        }
        // The below lines Print results
        System.out.println(legendary.get(firstWin) + " obtained!"); // search by key in collection lagendary


        materialsKey.entrySet() // using functional ways for sorted AND print
                .stream()
                .sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                .forEach(k -> System.out.println(k.getKey() + ": " + k.getValue()));

        junk.entrySet()
                .forEach(k -> System.out.println(k.getKey() + ": " + k.getValue())); // functional ways for print
    }
}
