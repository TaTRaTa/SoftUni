import java.util.*;
import java.util.stream.Collectors;

/**
 * Created by lenovo on 13.11.2015 ã..
 */
public class Pr_4_Weightlifting {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        TreeMap<String, TreeMap<String, Long>> map = new TreeMap<>();
        int N = Integer.parseInt(sc.nextLine());
        for (int i = 0; i < N; i++) {
            String input = sc.nextLine();
            String[] arg = input.split(" ");
            String player = arg[0];
            String exercise = arg[1];
            long weight = Long.parseLong(arg[2]);

            if (!map.containsKey(player)){
                map.put(player, new TreeMap<>());
            }
            if (!map.get(player).containsKey(exercise)){
                map.get(player).put(exercise, 0L);
            }
            long sum = map.get(player).get(exercise) + weight;
            map.get(player).put(exercise, sum);
        }

        List<String> list = new ArrayList<>();

        map.entrySet()
                .stream()
                .forEach(entry -> {
                    StringBuilder sb = new StringBuilder();
                    sb.append(String.format("%s :", entry.getKey()));

                    entry.getValue()
                            .entrySet()
                            .stream()
                            .forEach(a ->
                                    sb.append(String.format(" %s - %d kg,", a.getKey(), a.getValue())));
                    sb.append("\n");
                    list.add(sb.toString());

                });
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i).substring(0, list.get(i).length() - 2));
        }
    }

}


