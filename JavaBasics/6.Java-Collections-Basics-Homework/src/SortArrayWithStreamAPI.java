import com.sun.deploy.util.ArrayUtil;

import java.util.*;

/**
 * Created by lenovo on 26.10.2015 ã..
 */
public class SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        int[] nums = Arrays.asList(scr.nextLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
        String sort = scr.nextLine();
        switch (sort.toLowerCase()){
            case "ascending":
                Arrays.sort(nums);
                //System.out.println(nums);
                for (int num : nums) {
                    System.out.print(num + " ");
                }
                break;
            case "descending":
                Arrays.sort(nums);
                List<Integer> list = new ArrayList<>();
                for (int i = 0; i < nums.length; i++) {
                    list.add(nums[i]);
                }
                Collections.reverse(list);

                for (Integer integer : list) {
                    System.out.print(integer + " ");
                }
                break;
        }
    }
}
