package AdvancedCExam11October2015;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo on 4.11.2015 ã..
 */
public class Problem_4_Srubsko_Unleashed {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        LinkedHashMap<String, LinkedHashMap<String, Integer>> venueKey = new LinkedHashMap<>();

        String input = scn.nextLine();
        while (!input.equals("End")){
            Pattern pat = Pattern.compile("([a-zA-Z ]+)\\s@([a-zA-Z ]+)\\s(\\d+)\\s(\\d+)");
            Matcher match = pat.matcher(input);
            while (match.find()){
                String singer = match.group(1).trim();
                String venue = match.group(2).trim();
                int tickedPrice = Integer.parseInt(match.group(3).trim());
                int tickedCount = Integer.parseInt(match.group(4).trim());
                int sumMoney = tickedCount * tickedPrice;
                if (!venueKey.containsKey(venue)){
                    venueKey.put(venue, new LinkedHashMap<>());
                }
                if (!venueKey.get(venue).containsKey(singer)){
                    venueKey.get(venue).put(singer, 0);
                }
                int sum =  venueKey.get(venue).get(singer);
                venueKey.get(venue).put(singer, sum + sumMoney);

            }

            input = scn.nextLine();
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> stringHashMapEntry : venueKey.entrySet()) {
            System.out.println(stringHashMapEntry.getKey());

            stringHashMapEntry.getValue().entrySet()
                    .stream()
                    .sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                    .forEach(a -> System.out.println("#  " + a.getKey() + " -> " + a.getValue()));
        }


    }
}
