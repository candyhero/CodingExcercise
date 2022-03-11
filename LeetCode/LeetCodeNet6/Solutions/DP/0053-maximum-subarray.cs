namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/maximum-subarray/
    
Notes:
    let f(i) be max sum so far ending at i 
    f(i) = max(f(i-1)+arr[i], arr[i])
    f(0) = arr[0]
    solution = max(f(i)) where i in 0..n-1
*/
public class Solution53
{
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
}