namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/maximum-sum-circular-subarray/
*/
public class Solution918 
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        var maxSum = MaxSubArray(nums);
        var minSum = MinSubArray(nums);
        var totalSum = nums.Sum();

        if (minSum == totalSum)
        {
            return maxSum;
        }

        return Math.Max(maxSum, totalSum - minSum);
    }
    
    public int MaxSubArray(int[] nums)
    {
        int dp = nums[0], maxSum = dp;
        for (var i = 1; i < nums.Length; i++)
        {
            dp = Math.Max(0, dp) + nums[i];
            maxSum = Math.Max(maxSum, dp);
        }

        return maxSum;
    }
    
    public int MinSubArray(int[] nums)
    {
        int dp = nums[0], minSum = dp;
        for (var i = 1; i < nums.Length; i++)
        {
            dp = Math.Min(0, dp) + nums[i];
            minSum = Math.Min(minSum, dp);
        }

        return minSum;
    }
}