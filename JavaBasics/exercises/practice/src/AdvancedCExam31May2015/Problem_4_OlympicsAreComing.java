package AdvancedCExam31May2015;

import java.util.*;
import java.util.stream.Stream;

/**
 * Created by lenovo on 9.11.2015 ã..
 */
public class Problem_4_OlympicsAreComing {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        LinkedHashMap<String, LinkedHashMap<String, Integer>> map = new LinkedHashMap<>();
        LinkedHashMap<String, Integer> win = new LinkedHashMap<>();
        // The below lines read input AND fill "map" map
        String input = scn.nextLine();
        while (!input.equals("report")){
            String[] arg = input.split("\\|");
            String athlete = arg[0].replaceAll("\\s+", " ").trim();
            String country = arg[1].replaceAll("\\s+", " ").trim();
            if (!map.containsKey(country)){
                map.put(country, new LinkedHashMap<>());
            }

            if (!map.get(country).containsKey(athlete)){
                map.get(country).put(athlete, 0);
            }
            int wins =  map.get(country).get(athlete) + 1;
            map.get(country).put(athlete, wins);

            input = scn.nextLine();
        }
        //fill "win" map AND use "country" method for sum
        map.entrySet().stream().forEach(entry -> win.put(entry.getKey(), countryWdins(entry.getValue().entrySet())));

        // the below lines print result by functional ways
        win.entrySet()
                .stream()
                .sorted((a,b) -> b.getValue().compareTo(a.getValue()))
                .forEach(entry ->
                    System.out.printf("%s (%d participants): %d wins\n",
                            entry.getKey(),
                            map.get(entry.getKey()).size(),
                            win.get(entry.getKey())
                        ));

    }

    private static Integer countryWdins(Set<Map.Entry<String, Integer>> entrySet) {
        int sum = 0;
        for (Map.Entry<String, Integer> stringIntegerEntry : entrySet) {
            sum += stringIntegerEntry.getValue();
        }
        return sum;
    }
}
