namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link: 
    https://leetcode.com/problems/search-insert-position/
*/
public class Solution35 
{
    public int SearchInsert(int[] nums, int target)
    {
        return Helper(nums, 0, nums.Length - 1, target);
    }

    public int Helper(int[] nums, int lower, int upper, int target)
    {
        if (upper <= lower) return nums[lower] >= target ? lower : lower + 1;
        
        var mid = (lower + upper) / 2;
        if (nums[mid] > target) return Helper(nums, lower, mid - 1, target);
        if (nums[mid] < target) return Helper(nums, mid + 1, upper, target);
        return mid;
    }
}