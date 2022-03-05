namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link: 
    https://leetcode.com/problems/binary-search/
*/
public class Solution704 
{
    public int Search(int[] nums, int target)
    {
        return Helper(nums, 0, nums.Length - 1, target);
    }

    public int Helper(int[] nums, int lower, int upper, int target)
    {
        if (lower > upper) return -1;
        
        var mid = (lower + upper) / 2;
        if (target < nums[mid]) return Helper(nums, lower, mid - 1, target);
        if (target > nums[mid]) return Helper(nums, mid + 1, upper, target);
        return mid;
    }
}