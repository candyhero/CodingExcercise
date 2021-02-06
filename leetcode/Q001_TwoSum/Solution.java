package leetcode.Q001_TwoSum;

import java.util.HashMap;
import java.util.Map;

class Solution {
    public int[] twoSum(int[] nums, int target) {
        // Key: Complement value, Value: index
        Map<Integer, Integer> map = new HashMap<Integer, Integer>();
        for (int i = 0; i < nums.length; ++i) {
            int complement = target - nums[i];
            if(map.containsKey(complement)) {
                return new int[]{ i, map.get(complement) };
            } 
            map.put(nums[i], i);
        }
        return new int[0];
    }
}