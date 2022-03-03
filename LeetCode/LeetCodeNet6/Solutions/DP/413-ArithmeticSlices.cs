namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/arithmetic-slices/

Notes:
    f(i) = number of arithmetic slices ending with arr[i]
    f(i) = f(i-1) + 1 if arr[i] - arr[i-1] == arr[i-1] - arr[i-2] else 0
    f(0) = 0
    f(1) = 0

    g(n-1) = sum(f(i)) where i in 0..n-1
*/
public class Solution413
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        var dp = new int[nums.Length];
        var ret = 0;
        for (var i = 2; i < nums.Length; i++)
        {
            dp[i] = nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2]
                ? dp[i - 1] + 1
                : 0;
            ret += dp[i];
        }

        return ret;
    }
}