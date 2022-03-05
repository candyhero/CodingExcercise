namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/climbing-stairs/
 
Note: 
    f(n) be the number of distinct ways climbing from 0 to i
    f(n) = f(n-1) + f(n-2)
    f(0) = 1
    f(1) = 1
    
    Solution: f(n)
*/
public class Solution70
{
    public int ClimbStairs(int n)
    {
        var dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (var i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}