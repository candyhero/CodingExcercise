namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/min-cost-climbing-stairs/
    
Note: 
    f(n) be the min cost climbing to i so far
    f(n) = min(f(n-1), f(n-2) + arr[n]
    f(0) = arr[0]
    f(1) = arr[1]
    
    solution = min(f(n), f(n-1))
*/
public class Solution746
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var dp = new int[cost.Length];
        dp[0] = cost[0];
        dp[1] = cost[1];

        for (var i = 2; i < cost.Length; i++)
        {
            dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
        }

        return Math.Min(dp[^1], dp[^2]);
    }
}