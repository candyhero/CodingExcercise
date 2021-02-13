package leetcode.Q053_MaximumSubarray;

class Solution {
    public int maxSubArray(int[] nums) {
        int buffer = nums[0], result = buffer;
        for (int i = 1; i < nums.length; i++) {
            buffer = Math.max(buffer, 0) + nums[i];
            result = Math.max(result, buffer);
        }
        return result;
    }
}