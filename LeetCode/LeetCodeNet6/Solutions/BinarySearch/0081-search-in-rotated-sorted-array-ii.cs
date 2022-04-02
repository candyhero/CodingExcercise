namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link:
    https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
*/
public class Solution81
{
    public bool Search(int[] nums, int target) 
    {
        var lower = 0; 
        var upper = nums.Length - 1;

        while (lower <= upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (nums[mid] == target) 
            {
                return true;
            }
            else if (nums[lower] == nums[mid] && nums[mid] == nums[upper])
            {
                lower++;
                upper--;
            }
            else if (nums[lower] <= target && target < nums[mid]
                     || nums[mid] < nums[lower] && nums[lower] <= target
                     || target < nums[mid] && nums[mid] < nums[lower])
            {
                upper = mid - 1;
            } 
            else 
            {
                lower = mid + 1;
            }
        }

        return false;
    }
}