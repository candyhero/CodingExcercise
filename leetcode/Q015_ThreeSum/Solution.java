package leetcode.Q015_ThreeSum;

import java.util.*;
import templates.sorting.*;

public class Solution {
    private AdvancedQuickSort sortHelper = new AdvancedQuickSort(); 

    public static void main(String[] args) {
        Solution solution = new Solution();
        int[] input = new int[] { 0, 1, 2, 13, 4, 5, 6, 7, 8, 9, -1 };
        System.out.println(solution.threeSum(input).size());
    } 

    // Sort + Two pointers approach, need optimization
    public List<List<Integer>> threeSum(int[] nums) {
        List<List<Integer>> result = new ArrayList<List<Integer>>(); 
        if (nums.length < 3) return result;

        sort(nums);

        Set<String> set = new HashSet<String>();
        for (int i = 0; i < nums.length - 2; i++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;
            int targetSum = -nums[i];
            int lowPtr = i + 1, highPtr = nums.length - 1;
            while (lowPtr < highPtr) {
                int currentSum = nums[lowPtr] + nums[highPtr];
                String hash = String.format("%d,%d,%d", nums[i], nums[lowPtr], nums[highPtr]);
                if (currentSum == targetSum && !set.contains(hash)) {
                    result.add(Arrays.asList(nums[i], nums[lowPtr], nums[highPtr]));
                    set.add(hash);
                }
                if(currentSum < targetSum) lowPtr++; 
                else highPtr--;
            }
        }
        return result;
    }
    
    private void sort(int[] nums) {
        advancedQuickSort(nums, 0, nums.length - 1);
    }

    // low & high are both inclusive / closed interval
    private void advancedQuickSort(int[] nums, int low, int high) {
        if (high - low < 10) { 
            insertionSort(nums, low, high);
            System.out.println("Yo Insertion!");
            return;
        }
        int p = partition(nums, low, high);
        advancedQuickSort(nums, low, p);
        advancedQuickSort(nums, p + 1, high);
    }

    private void insertionSort(int[] nums, int low, int high) {
        for(int i = low +1; i <= high; i++) 
        { 
            int val = nums[i]; 
            int j = i ; 
            while (j > low && nums [j - 1] > val) 
            { 
                nums[j] = nums[j - 1] ; 
                j -= 1; 
            } 
            nums[j] = val ; 
        }  
    }    

    // guaranteed to have at least 3 elements in [low..high]
    private int partition(int[] nums, int low, int high) {     
        int pivot = getPivotIndex(nums, low, high);
        int pivotValue = nums[pivot];
        int lowPtr = low - 1, highPtr = high + 1;
        while (true) {
            while (nums[++lowPtr] < pivotValue) {}
            while (nums[--highPtr] > pivotValue) {}
            if (lowPtr >= highPtr) return highPtr;
            swap(nums, lowPtr, highPtr);
        }
    }

    private int getPivotIndex(int[] nums, int low, int high) {
        int oneThird = (high - low + 1) / 3;
        int med3Low = med3(nums, low, low + oneThird - 1);
        int med3Mid = med3(nums, low + oneThird, high - oneThird);
        int med3High = med3(nums, high - oneThird + 1, high);
        return med3(nums, med3Low, med3Mid, med3High); 
    }

    // return median index
    private int med3(int[] nums, int low, int high) {
        int mid = (low + high) / 2;
        return med3(nums, low, mid, high);
    }

    private int med3(int[] nums, int a, int b, int c) {
        if ((nums[a] <= nums[b] && nums[b] <= nums[c]) 
            || (nums[a] >= nums[b] && nums[b] >= nums[c])) 
            return b;

        if ((nums[b] <= nums[a] && nums[a] <= nums[c]) 
            || (nums[b] >= nums[a] && nums[a] >= nums[c])) 
            return a;

        return c;
    }

    private void swap(int[] nums, int a, int b) {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}