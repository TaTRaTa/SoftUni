package AdvancedCExam19July2015;

import java.util.*;

/**
 * Created by lenovo on 6.11.2015 ã..
 */
public class Problem_4_PopulationCounter {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        Map<String, Long> totalSum = new LinkedHashMap<>();
        LinkedHashMap<String, LinkedHashMap<String, Long>> map = new LinkedHashMap<>();
        String input = scn.nextLine();
        while (!input.equals("report")) {
            String[] arg = input.split("\\|");
            String city = arg[0];
            String country = arg[1];
            long population = Long.parseLong(arg[2]);
            if (!map.containsKey(country)) {
                map.put(country, new LinkedHashMap<>());
            }
            if (!totalSum.containsKey(country)) {
                totalSum.put(country, 0L);
            }
            if (!map.get(country).containsKey(city)) {
                map.get(country).put(city, population);
            }
            totalSum.put(country, totalSum.get(country) + population);
            input = scn.nextLine();
        }

        totalSum.entrySet()
                .stream()
                .sorted((a,b) -> b.getValue().compareTo(a.getValue()))
                .forEach(entry -> {

                        System.out.printf("%s(total population: %d)\n",
                                entry.getKey(),
                                entry.getValue()
                        );
                        map.get(entry.getKey()).entrySet()
                                .stream()
                                .sorted((a,b)-> b.getValue().compareTo(a.getValue()) )
                                .forEach(m -> System.out.printf("=>%s: %d\n",
                                        m.getKey(),
                                        m.getValue()));
                    });




    }
}


