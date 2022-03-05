using System.Globalization;

namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link: 
    https://leetcode.com/problems/squares-of-a-sorted-array/

Notes:
    O(n), just use two pointers start from middle of the sorted array
    one moving backward (negative)
    one moving forward (positive)
*/
public class Solution977
{
    public int[] SortedSquares(int[] nums)
    {
        var ret = new int[nums.Length];
        var positiveIndex = FindIndexOfFirstPositive(nums);
        var nonPositiveIndex = positiveIndex - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nonPositiveIndex >= 0 && positiveIndex < nums.Length)
            {
                if (nums[positiveIndex] < Math.Abs(nums[nonPositiveIndex]))
                    ret[i] = nums[positiveIndex++];
                else
                    ret[i] = nums[nonPositiveIndex--];
            }
            else if (nonPositiveIndex < 0) // non positive exhausted
                ret[i] = nums[positiveIndex++];
            else if (positiveIndex >= nums.Length) // positive exhausted
                ret[i] = nums[nonPositiveIndex--];

            ret[i] *= ret[i];
        }

        return ret;
    }

    private int FindIndexOfFirstPositive(int[] nums)
    {
        if (nums[0] > 0) return 0; // All positives
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] <= 0 && nums[i] > 0) return i;
        }

        return nums.Length; // All negatives
    }
}