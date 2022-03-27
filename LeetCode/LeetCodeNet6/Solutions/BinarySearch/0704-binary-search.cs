namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link: 
    https://leetcode.com/problems/binary-search/
*/
public class Solution704 
{
    public int Search(int[] nums, int target)
    {
        var lower = 0;
        var upper = nums.Length - 1;
        
        while (lower <= upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (target < nums[mid]) upper = mid - 1;
            else if (target > nums[mid]) lower = mid + 1;
            else return mid;
        }

        return -1;
    }
}