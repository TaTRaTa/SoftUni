package JavaFundamentals4October2015;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by lenovo on 8.11.2015 ã..
 */
public class Problem_4_DragonArmy {
    public final static int DEFAULT_DAMAGE = 45;
    public final static int DEFAULT_HEALTH = 250;
    public final static int DEFAULT_ARMOR = 10;

    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        LinkedHashMap<String, TreeMap<String, int[]>> map = new LinkedHashMap<>();
        int N = Integer.parseInt(scn.nextLine().trim());

        for (int i = 0; i < N; i++) {
            String[] input = scn.nextLine().split(" ");
            String type = input[0].trim();
            String name = input[1].trim();
            int damage = input[2].equals("null")? DEFAULT_DAMAGE : Integer.parseInt(input[2].trim());
            int health = input[3].equals("null")? DEFAULT_HEALTH : Integer.parseInt(input[3].trim());
            int armor  = input[4].equals("null")? DEFAULT_ARMOR  : Integer.parseInt(input[4].trim());

            if (!map.containsKey(type)) {
                map.put(type, new TreeMap<>());
            }
            if (!map.get(type).containsKey(name)) {
                map.get(type).put(name, new int[3]);
            }
            map.get(type).get(name)[0] = damage;
            map.get(type).get(name)[1] = health;
            map.get(type).get(name)[2] = armor;
        }
        // The below lines print result

        map.entrySet()
           .stream()
           .forEach(entry -> {
               System.out.printf("%s::%s\n",
                             entry.getKey(),
                             DragonsStats(entry.getValue()));
               entry.getValue()
                       .entrySet()
                       .stream()
                       .forEach(pair -> System.out.printf("-%s -> damage: %d, health: %d, armor: %d\n",
                               pair.getKey(),
                               pair.getValue()[0],
                               pair.getValue()[1],
                               pair.getValue()[2]));
           });

    }

    private static String DragonsStats(TreeMap<String, int[]> dragons) {

        int count = dragons.size();
        double damage = 0;
        double health = 0;
        double armor  = 0;
        for (Map.Entry<String, int[]> stringEntry : dragons.entrySet()) {
            damage += stringEntry.getValue()[0];
            health += stringEntry.getValue()[1];
            armor  += stringEntry.getValue()[2];
        }

        return String.format("(%.2f/%.2f/%.2f)", (damage / count), (health / count), (armor / count));

    }

}
