namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link:
    https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
*/
public class Solution34 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        var lower = SearchLower(nums, target);
        if (lower == -1) 
        {
            return new[] { -1, -1 };
        }

        var upper = SearchUpper(nums, target, lower);
        return new[] { lower, upper };
    }

    public int SearchLower(int[] nums, int target)
    {
        var lower = 0;
        var upper = nums.Length - 1;

        while (lower < upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (nums[mid] >= target) upper = mid;
            else lower = mid + 1;
        }

        if (lower < nums.Length && nums[lower] == target)
        {
            return lower;
        }

        return -1;
    }

    public int SearchUpper(int[] nums, int target, int lowerBound)
    {
        var lower = lowerBound;
        var upper = nums.Length - 1;

        while (lower < upper)
        {
            var mid = lower + (upper - lower + 1) / 2;
            if (nums[mid] <= target) lower = mid;
            else upper = mid + 1;
        }

        if (upper >= 0 && nums[upper] == target)
        {
            return upper;
        }

        return -1;
    }
}