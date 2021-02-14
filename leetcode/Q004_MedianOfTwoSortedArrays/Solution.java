package leetcode.Q004_MedianOfTwoSortedArrays;

import java.util.*;

class Solution {
    public static void main(String[] args) {
        int[] nums1 = new int[] {};
        int[] nums2 = new int[] {2,3};
        Solution solution = new Solution();
        solution.findMedianSortedArrays(nums1, nums2);
    }
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.length == 0 && nums2.length == 0) { return 0; }

        int i1 = 0, i2 = 0, size = nums1.length + nums2.length;
        List<Integer> buffer = new ArrayList<Integer>();
        while (buffer.size() <= size / 2) {
            if (i1 >= nums1.length) { buffer.add(nums2[i2++]); }
            else if (i2 >= nums2.length) { buffer.add(nums1[i1++]); }
            else if (nums1[i1] < nums2[i2]) { buffer.add(nums1[i1++]); }
            else { buffer.add(nums2[i2++]); }
        }
        int i = buffer.size() - 1;
        return size % 2 == 1
            ? buffer.get(i)
            : (buffer.get(i) + buffer.get(i-1)) / 2.0;
    }
}